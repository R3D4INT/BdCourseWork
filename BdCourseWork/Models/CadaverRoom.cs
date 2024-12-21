namespace BdCourseWork.Models
{
    public class CadaverRoom : BaseEntity
    {
        public int CadaverRoomNumber { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Length { get; set; }

        public decimal Temperature { get; set; }

        public int MorgueWorkerId { get; set; }

        public MorgueWorker MorgueWorker { get; set; }

        public Cadaver Cadaver { get; set; }
    }
}
