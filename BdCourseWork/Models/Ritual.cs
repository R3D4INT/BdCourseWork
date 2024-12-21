using BdCourseWork.Models.enums;

namespace BdCourseWork.Models
{
    public class Ritual : BaseEntity
    {
        public DateTime DateOfExecution { get; set; }

        public decimal Cost { get; set; }

        public RitualType RitualType { get; set; }

        public int CadaverId { get; set; }

        public Cadaver Cadaver { get; set; }

        public int FunerealAgencyWorkerId { get; set; }

        public FunerealAgencyWorker FunerealAgencyWorker { get; set; }

        public Ashes Ashes { get; set; }
    }
}
