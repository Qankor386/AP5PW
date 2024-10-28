using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Domain.Entities
{
    public class Doctor : Entity<int>
    {
        [Required]
        public string Specialization { get; set; }

        public int YearsOfExperience { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}