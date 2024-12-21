namespace BdCourseWork.Models
{
    public class MorgueWorker
    {
        public Morgue Morgue { get; set; }
        
        public int MorgueId { get; set; }

        public Worker Worker { get; set; }

        public int WorkerId { get; set; }

        public ICollection<CadaverRoom> CadaverRooms { get; set; } = new List<CadaverRoom>();
    }
}
