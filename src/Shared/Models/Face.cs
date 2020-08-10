namespace FaceManagement.Shared.Models
{
    public record Face
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public double[] Encoding { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
