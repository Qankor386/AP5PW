using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities
{
    public class Result : Entity<int>
    {
        public DateTime CreatedDate { get; set; }
        public required string ResultsDescription { get; set; }

        [ForeignKey(nameof(Registration))]
        public int RegistrationId { get; set; }
        public required Registration Registration { get; set; }
    }
}