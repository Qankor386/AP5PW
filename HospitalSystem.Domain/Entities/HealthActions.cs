using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Domain.Entities
{
    public class HealthAction : Entity<int>
    {
        public string ProcedureName { get; set; }
        public string ProcedureDescription { get; set; }

        public virtual ICollection<BloodTest> BloodTests { get; set; }
        public virtual ICollection<Vaccination> Vaccinations { get; set; }
    }

    public class BloodTest : Entity<int>
    {
        public string BloodType { get; set; }
        public string ProcedureNotes { get; set; }

        [ForeignKey("HealthAction")]
        public int HealthActionId { get; set; }
        public HealthAction HealthAction { get; set; }
    }

    public class Vaccination : Entity<int>
    {
        public string VaccinationType { get; set; }
        public string SideEffects { get; set; }

        [ForeignKey("HealthAction")]
        public int HealthActionId { get; set; }
        public HealthAction HealthAction { get; set; }
    }
}