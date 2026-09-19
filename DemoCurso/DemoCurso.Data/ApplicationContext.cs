using DemoCurso.Domain;
using Microsoft.EntityFrameworkCore;

namespace DemoCurso.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        public ApplicationContext()
        {
        }
        public DbSet<Curso> Cursos { get; set; }

     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.ToTable("Curso");

                entity.HasKey(c => c.Id);

                entity.Property(c => c.Id)
                      .ValueGeneratedOnAdd();

                entity.Property(c => c.Descricao)
                      .IsRequired()
                      .HasMaxLength(255);
            });
        }
    }
}
