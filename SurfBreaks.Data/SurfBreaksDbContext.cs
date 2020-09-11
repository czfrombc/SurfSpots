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
    }
}
