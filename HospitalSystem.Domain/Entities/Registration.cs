using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities
{
    public class Registration : Entity<int>
    {
        public required string RegistrationType { get; set; }
        public required string ProcedureDescription { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExecutionDate { get; set; }
        public required string Status { get; set; }

        [ForeignKey(nameof(UserAccount))]
        public int UserAccountId { get; set; }
        public required UserAccount UserAccount { get; set; }

        public required virtual ICollection<Result> Results { get; set; } = new List<Result>();
    }
}