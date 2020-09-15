using SurfBreaks.Core;
using Microsoft.EntityFrameworkCore;

namespace SurfBreaks.Data
{
    public class SurfBreaksDbContext : DbContext
    {
        public SurfBreaksDbContext(DbContextOptions<SurfBreaksDbContext> options) : base(options)
        {

        }

        public DbSet<SurfBreak> SurfBreaks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SurfBreak>().HasData(
                new SurfBreak
                {
                    Id = 100,
                    Name = "Puerto Escondido",
                    Location = "Oaxaca",
                    Break = SurfBreak.BreakType.Beach
                },
                new SurfBreak
                {
                    Id = 101,
                    Name = "Pipeline",
                    Location = "Oahu",
                    Break = SurfBreak.BreakType.Reef
                }
            );
        }
    }
}
