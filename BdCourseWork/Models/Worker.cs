namespace BdCourseWork.Models
{
    public class Worker :  BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public decimal Salary { get; set; }

        public DateTime DateOfStart { get; set; }

        public int VacationAmount { get; set; }

        public string Position { get; set; }

        public string ContactEmail { get; set; }

        public string PlaceOfResidence { get; set; }

        public string TaxNumber { get; set; }

        public ICollection<MorgueWorker> MorgueWorkers { get; set; } = new List<MorgueWorker>();

        public ICollection<FunerealAgencyWorker> FunerealAgencyWorkers { get; set; } = new List<FunerealAgencyWorker>();
    }
}
