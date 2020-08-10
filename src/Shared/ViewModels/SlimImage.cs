using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceManagement.Shared.ViewModels
{

    public class SlimImage
    {
        public string server { get; set; }
        public Input input { get; set; }
        public Output output { get; set; }
        public Actions actions { get; set; }
    }

    public class Input
    {
        public string name { get; set; }
        public string type { get; set; }
        public int size { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public object field { get; set; }
    }

    public class Output
    {
        public string name { get; set; }
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string image { get; set; }
    }

    public class Actions
    {
        public object rotation { get; set; }
        public Crop crop { get; set; }
        public object size { get; set; }
        public Filters filters { get; set; }
        public Minsize minSize { get; set; }
    }

    public class Crop
    {
        public double x { get; set; }
        public double y { get; set; }
        public double height { get; set; }
        public double width { get; set; }
        public string type { get; set; }
    }

    public class Filters
    {
        public int sharpen { get; set; }
    }

    public class Minsize
    {
        public int width { get; set; }
        public int height { get; set; }
    }

}
