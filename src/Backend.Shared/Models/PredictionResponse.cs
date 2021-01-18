using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Backend.Shared.Models
{
    public class PredictionResponse
    {
        [JsonPropertyName("predictions")]
        public float[][] Encodings { get; set; }
    }
}
