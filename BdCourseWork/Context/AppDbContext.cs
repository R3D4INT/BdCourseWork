using BdCourseWork.Models;
using Microsoft.EntityFrameworkCore;

namespace BdCourseWork.Context 
{
    public class AppDbContext : DbContext
    {
        DbSet<Worker> Workers;

        DbSet<Morgue> Morgues;

        DbSet<MorgueWorker> MorguesWorkers;

        DbSet<CadaverRoom> CadaverRooms;

        DbSet<Cadaver> Cadavers;

        DbSet<FunerealAgency> FunerealAgencies;

        DbSet<FunerealAgencyWorker> FunerealAgenciesWorkers;

        DbSet<Ritual> Rituals;

        DbSet<Ashes> Ashes;

        DbSet<Urn> Urnes;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
          
        }

        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("Course_Work");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
