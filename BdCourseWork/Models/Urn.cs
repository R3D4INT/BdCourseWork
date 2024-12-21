namespace BdCourseWork.Models
{
    public class Urn : BaseEntity
    {
        public string Color { get; set; }

        public string Material { get; set; }

        public string Size { get; set; }

        public int AshedId { get; set; }

        public Ashes Ashes { get; set; }
    }
}
