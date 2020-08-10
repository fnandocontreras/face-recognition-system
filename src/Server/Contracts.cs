using System.Drawing;
using System.IO;

namespace FaceManagement.Server
{
    public class Contracts
    {
        public static string ImagesFolderPath => Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img");

        public static Size ImageSize => new Size(300, 300);
    }
}
