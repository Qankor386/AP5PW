using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Domain.Entities
{
    public class Role : Entity<int>
    {
        [Required]
        public string RoleName { get; set; }

        public virtual ICollection<UserAccount> UserAccounts { get; set; }
    }
}