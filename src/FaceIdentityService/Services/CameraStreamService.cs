using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace FaceIdentityService.Services
{
    public class CameraStreamService: CamStream.CamStreamBase
    {
        private readonly ILogger<CameraStreamService> _logger;
        private readonly TensorflowServiceClient _tfService;

        public CameraStreamService(
            ILogger<CameraStreamService> logger, 
            TensorflowServiceClient tfService)
        {
            _logger = logger;
            _tfService = tfService;
        }

        public async Task ProcessCameraStream(
            IAsyncStreamReader<CameraFrame> requestStream, 
            IServerStreamWriter<Annotation> responseStream,
            ServerCallContext context)
        {
            try
            {
                while(await requestStream.MoveNext())
                {
                    var frame = requestStream.Current;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
