using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities
{
    [Table(nameof(HealthAction))]
    public class HealthAction : Entity<int>
    {
        public required string ProcedureName { get; set; }
        public required string ProcedureDescription { get; set; }

        public required virtual ICollection<BloodTest> BloodTests { get; set; }
        public required virtual ICollection<Vaccination> Vaccinations { get; set; }
    }

    [Table(nameof(BloodTest))]
    public class BloodTest : Entity<int>
    {
        public required string BloodType { get; set; }
        public required string ProcedureNotes { get; set; }

        [ForeignKey(nameof(HealthAction))]
        public int HealthActionId { get; set; }
        public required HealthAction HealthAction { get; set; }
    }

    [Table(nameof(Vaccination))]
    public class Vaccination : Entity<int>
    {
        public required string VaccinationType { get; set; }
        public required string SideEffects { get; set; }

        [ForeignKey(nameof(HealthAction))]
        public int HealthActionId { get; set; }
        public required HealthAction HealthAction { get; set; }
    }
}