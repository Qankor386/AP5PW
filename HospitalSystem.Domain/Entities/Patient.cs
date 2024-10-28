using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities
{
    [Table(nameof(Patient))]
    public class Patient : Entity<int>
    {
        public required string BirthNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string HealthInsurance { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public required Person Person { get; set; }
    }
}