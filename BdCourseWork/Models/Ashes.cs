namespace BdCourseWork.Models
{
    public class Ashes : BaseEntity
    {
        public decimal Weight { get; set; }

        public int RitualId { get; set; }

        public Ritual Ritual { get; set; }

        public Urn Urn { get; set; }
    }
}
