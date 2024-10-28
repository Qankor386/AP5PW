using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Domain.Entities
{
    public class Result : Entity<int>
    {
        public DateTime CreatedDate { get; set; }
        public string ResultsDescription { get; set; }

        [ForeignKey("Registration")]
        public int RegistrationId { get; set; }
        public Registration Registration { get; set; }
    }
}