using BdCourseWork.Models.enums;

namespace BdCourseWork.Models
{
    public class Cadaver : BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfDeath { get; set; }

        public string DeathCause { get; set; }

        public Sex Sex { get; set; }

        public bool IsTattoed { get; set; }

        public string Nationality { get; set; }

        public int CadaverRoomId { get; set; }

        public CadaverRoom CadaverRoom { get; set; }

        public Ritual Ritual { get; set; }
    }
}
