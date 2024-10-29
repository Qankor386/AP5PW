using Microsoft.EntityFrameworkCore;
using HospitalSystem.Domain.Entities;

namespace HospitalSystem.Infrastructure.Database
{
    public class HospitalSystemDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        
        public HospitalSystemDbContext(DbContextOptions DbContextOptions) : base(DbContextOptions)
        {
        }
    }
}