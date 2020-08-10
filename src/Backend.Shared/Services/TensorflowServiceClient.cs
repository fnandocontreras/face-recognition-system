using Backend.Shared.Models;
using Backend.Shared.Settings;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tensorflow.Serving;
using Tensorflow.Utils;

namespace FaceIdentityService.Services
{
    public class TensorflowServiceClient
    {
        TensorflowServiceSettings _settings;
        ILogger<TensorflowServiceClient> _logger;
        public TensorflowServiceClient(
            IOptions<TensorflowServiceSettings> settings,
            ILogger<TensorflowServiceClient> logger)
        {
            _settings = settings.Value;
            _logger = logger;
        }

        public async Task<PredictionResult> GetFaceEncoding(string base64Image)
        {
            try
            {
                var stopWatch = Stopwatch.StartNew();
                var imageData = CreateImageDataFromModel(base64Image);

                //Init predict request
                var request = new PredictRequest()
                {
                    ModelSpec = new ModelSpec() { Name = "siamese_network_face", SignatureName = "" }
                };
                request.Inputs.Add("input_1", TensorBuilder.CreateTensorFromImage(imageData, 1.0f, 0f));

                //Create grpc request
                var channel = new Channel(_settings.ServiceUrl, ChannelCredentials.Insecure);
                var client = new PredictionService.PredictionServiceClient(channel);
                var predictResponse = client.Predict(request);

                _logger.LogInformation("predicted in {ms} ms", stopWatch.ElapsedMilliseconds);

                //Process response
                var predictedIndex = predictResponse.Outputs["dense"].FloatVal.Max() > 0 ? 1 : 0;
                var predictionResults = new double[2] { 0, 0 };
                predictionResults[predictedIndex] = predictResponse.Outputs["dense"].FloatVal.Max();

                return new PredictionResult()
                {
                    Success = true,
                    Encoding = predictionResults,
                };

            }
            catch (Exception ex)
            {
                return ErrorResult(ex);
            }
        }
        private (int, int, int)[][] CreateImageDataFromModel(string modelImageData)
        {
            Bitmap convertedImage = null;

            using (var str = new MemoryStream(Convert.FromBase64String(modelImageData)))
            {
                str.Position = 0;
                using (var bmp = Image.FromStream(str))
                {
                    convertedImage = ImageUtils.ResizeImage(bmp, 96, 96, bmp.Width, bmp.Height);
                }
            }

            var imageData = ImageUtils.ConvertImageStreamToDimArraysColor(convertedImage);

            return imageData;
        }

        private PredictionResult ErrorResult(Exception ex) => new PredictionResult()
        {
            Success = false,
            ErrorMessage = ex.ToString()
        };



    }
}
