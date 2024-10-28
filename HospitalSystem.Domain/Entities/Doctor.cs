using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities
{
    [Table(nameof(Doctor))]
    public class Doctor : Entity<int>
    {
        [Required]
        public required string Specialization { get; set; }

        public int YearsOfExperience { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public required Person Person { get; set; }
    }
}