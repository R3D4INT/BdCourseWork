namespace BdCourseWork.Models
{
    public class Morgue : BaseEntity
    {
        public string Address { get; set; }

        public string Title { get; set; }

        public int Capacity {get; set; }

        public int OccupedCadaverRooms {get; set; }

        public int AmountOfWorkers {get; set; }

        public string ContactNumber { get; set; }

        public string WorkingHours {get; set; }

        public ICollection<MorgueWorker> MorgueWorkers { get; set; } = new List<MorgueWorker>();

        public ICollection<FunerealAgencyWorker> FunerealAgencyWorkers { get; set; } = new List<FunerealAgencyWorker>();
    }
}
