using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Shared.Settings
{
    public class TensorflowServiceSettings
    {
        public string ServiceUrl { get; set; }
        public string HttpPort { get; set; }
        public string GrpcPort { get; set; }
    }
}
