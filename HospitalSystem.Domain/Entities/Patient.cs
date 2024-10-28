using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Domain.Entities
{
    public class Patient : Entity<int>
    {
        public string BirthNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HealthInsurance { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}