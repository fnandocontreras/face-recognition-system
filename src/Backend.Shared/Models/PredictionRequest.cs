using System.Text.Json.Serialization;

namespace Backend.Shared.Models
{
    class PredictionRequest
    {
        [JsonPropertyName("signature_name")]
        public string SignatureName { get; set; }

        [JsonPropertyName("instances")]
        public float[][][][] Instances { get; set; }
    }
}
