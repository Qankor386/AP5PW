using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities
{
    public class UserAccount : Entity<int>
    {
        [Required]
        public required string PersonalID { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Password { get; set; }

        public DateTime CreatedAt { get; set; }

        public required virtual ICollection<Role> Roles { get; set; } = new List<Role>();
        public required virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}