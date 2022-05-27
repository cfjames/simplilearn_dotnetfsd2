using Microsoft.EntityFrameworkCore;

namespace Phase2Section2._18.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() { }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        { }
        
        public DbSet<StudentModel> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Address)
                    .IsUnicode(false);

                entity.Property(e => e.Course)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsUnicode(false);

                entity.Property(e => e.ParentName)
                    .IsUnicode(false);
            });
        }
    }
}
