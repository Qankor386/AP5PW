using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Domain.Entities
{
    public class Registration : Entity<int>
    {
        public string RegistrationType { get; set; }
        public string ProcedureDescription { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExecutionDate { get; set; }
        public string Status { get; set; }

        [ForeignKey("UserAccount")]
        public int UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}