using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Domain.Entities
{
    public class Role : Entity<int>
    {
        [Required]
        public required string RoleName { get; set; }

        public required virtual ICollection<UserAccount> UserAccounts { get; set; }
    }
}