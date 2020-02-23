using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace University.DAL.Model
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=UniversityDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(student => student.FirstName)
                .HasMaxLength(50);
            modelBuilder.Entity<Student>()
                .Property(student => student.LastName)
                .HasMaxLength(50);

            modelBuilder.Entity<Course>()
                .HasMany<Student>(course => course.Students)
                .WithOne(student => student.Course);

            modelBuilder.Entity<Department>()
                .HasMany<Course>(department => department.Courses)
                .WithOne(course => course.Department);
        }
    }
}
