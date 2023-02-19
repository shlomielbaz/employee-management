using EM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EM.Data
{
    public class EMContext : DbContext
    {
        public EMContext(DbContextOptions<EMContext> options)
            : base(options)
        {
        }

        public EMContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"../", "EM.Data", "em-database.db"));
            optionsBuilder.UseSqlite($"Filename={dbPath}", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Employee> Employees { get; set; } = default!;
        public DbSet<Department> Departments { get; set; } = default!;
        public DbSet<Domain.Entities.Task> Tasks { get; set; } = default!;
        public DbSet<Report> Reports { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasIndex(p => new { p.Name })
                .IsUnique(true);

            modelBuilder.Entity<Employee>().HasOne(e => e.Manager)
                .WithMany()
                .HasForeignKey(m => m.ManagerId);
        }
    }
}
