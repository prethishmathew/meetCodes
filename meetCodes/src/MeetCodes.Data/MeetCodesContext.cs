using MeetCodes.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetCodes.Data
{
    public class MeetCodesContext:DbContext
    {
        public MeetCodesContext(DbContextOptions options) :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeetCode>()
                .ToTable("MeetCode");

            modelBuilder.Entity<MeetCode>()
                .Property(b => b.Code)
                .HasColumnName("Code");
        }
        public DbSet<MeetCode> MeetCodes { get; set; }
    }
}
