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
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using Tensorflow.Serving;
using Tensorflow.Utils;

namespace FaceIdentityService.Services
{
    public class TensorflowServiceClientRest
    {
        TensorflowServiceSettings _settings;
        ILogger<TensorflowServiceClientRest> _logger;
        HttpClient _httpClient;
        public TensorflowServiceClientRest(
            IOptions<TensorflowServiceSettings> settings,
            HttpClient httpClient,
            ILogger<TensorflowServiceClientRest> logger)
        {
            _settings = settings.Value;
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<PredictionResult> GetFaceEncoding(string base64Image)
        {
            try
            {
                var stopWatch = Stopwatch.StartNew();
                var imageData = CreateImageDataFromModel(base64Image);
                var tensors = TensorBuilder.CreateTensorFromImage(imageData, 1.0f, 0f).FloatVal.ToList();


                //Init predict request
                var request = new PredictionRequest()
                {
                    SignatureName = "", Instances = new float[1][][][]
                };
                request.Instances[0] = new float[96][][];
                for(int i = 0; i < 96; i++)
                {
                    request.Instances[0][i] = new float[96][];
                    for (int j = 0; j < 96; j++)
                    {
                        request.Instances[0][i][j] = new float[3];
                        request.Instances[0][i][j][0] = tensors[(i * 96 + j) * 3];
                        request.Instances[0][i][j][1] = tensors[(i * 96 + j) * 3 + 1];
                        request.Instances[0][i][j][2] = tensors[(i * 96 + j) * 3 + 2];
                    }
                }

                var result = await _httpClient.PostAsync(_settings.ServiceUrl,
                    new StringContent(JsonSerializer.Serialize(request)));

                //Process response
                var content = await result.Content.ReadAsStringAsync();
                var predictionRestResponse = JsonSerializer.Deserialize<PredictionResponse>(content);
                //Process response
                

                return new PredictionResult()
                {
                    Success = true
                   
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
