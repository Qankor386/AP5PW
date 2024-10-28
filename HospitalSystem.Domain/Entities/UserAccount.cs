using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Domain.Entities
{
    public class UserAccount : Entity<int>
    {
        [Required]
        public string PersonalID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}