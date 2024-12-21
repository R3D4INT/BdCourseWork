namespace BdCourseWork.Models
{
    public class FunerealAgencyWorker
    {
        public FunerealAgency FunerealAgency { get; set; }

        public int FunerealAgencyId { get; set; }

        public Worker Worker { get; set; }

        public int WorkerId { get; set; }

        public ICollection<Ritual> Rituals { get; set; } = new List<Ritual>();
    }
}
