using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Shared.Models
{
    public class PredictionResult
    {
        public double[] Encoding { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public string DebugText { get; set; }
    }
}
