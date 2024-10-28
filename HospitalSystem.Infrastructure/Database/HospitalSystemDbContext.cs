using Microsoft.EntityFrameworkCore;
using HospitalSystem.Domain.Entities;
using HospitalSystem.Infrastructure.Database;

namespace HospitalSystem.Infrastructure.Database
{
    public class HospitalSystemDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        
        public HospitalSystemDbContext(DbContextOptions<HospitalSystemDbContext> options) : base(options)
        {
        }
    }
}