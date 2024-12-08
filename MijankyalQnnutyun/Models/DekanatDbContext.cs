using Microsoft.EntityFrameworkCore;
namespace MijankyalQnnutyun.Models;

public partial class DekanatDbContext : DbContext
{
    public DekanatDbContext(DbContextOptions<DekanatDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Learning> Learnings { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.FacultyConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.LearningConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
