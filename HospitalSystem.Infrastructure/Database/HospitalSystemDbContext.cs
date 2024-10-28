using Microsoft.EntityFrameworkCore;
using HospitalSystem.Domain.Entities;
using HospitalSystem.Infrastructure.Database.Seeding;

namespace HospitalSystem.Infrastructure.Database
{
    public class HospitalSystemDbContext : DbContext
    {
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public HospitalSystemDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}