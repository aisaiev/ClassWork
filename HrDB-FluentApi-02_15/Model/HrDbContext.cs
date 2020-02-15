using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrDB_FluentApi_02_15.Model
{
    public class HrDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<JobGrade> JobGrades { get; set; }

        public DbSet<JobHistory> JobHistories { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Region> Regions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=HrDBFluent;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>()
                .Property(region => region.RegionName)
                .HasMaxLength(25);
            modelBuilder.Entity<Region>()
                .HasMany<Country>(region => region.Countries)
                .WithOne(country => country.Region);

            modelBuilder.Entity<Country>()
                .Property(country => country.CountryId)
                .HasMaxLength(2);
            modelBuilder.Entity<Country>()
                .Property(country => country.CountryName)
                .HasMaxLength(40);
            modelBuilder.Entity<Country>()
                .HasMany<Location>(country => country.Locations)
                .WithOne(location => location.Country);

            modelBuilder.Entity<Location>()
                .Property(location => location.StreetAddress)
                .HasMaxLength(25);
            modelBuilder.Entity<Location>()
                .Property(location => location.PostalCode)
                .HasMaxLength(12);
            modelBuilder.Entity<Location>()
                .Property(location => location.City)
                .HasMaxLength(30);
            modelBuilder.Entity<Location>()
                .Property(location => location.StateProvince)
                .HasMaxLength(12);
            modelBuilder.Entity<Location>()
                .HasMany<Department>(location => location.Departments)
                .WithOne(department => department.Location);

            modelBuilder.Entity<Department>()
                .Property(department => department.DepartmentName)
                .HasMaxLength(30);
            modelBuilder.Entity<Department>()
                .HasMany<JobHistory>(department => department.JobHistories)
                .WithOne(jobHistory => jobHistory.Department);
            modelBuilder.Entity<Department>()
                .HasMany<Employee>(department => department.Employees)
                .WithOne(employee => employee.Department);

            modelBuilder.Entity<Job>()
                .Property(job => job.JobId)
                .HasMaxLength(10);
            modelBuilder.Entity<Job>()
                .Property(job => job.JobTitle)
                .HasMaxLength(35);
            modelBuilder.Entity<Job>()
                .HasMany<JobHistory>(job => job.JobHistories)
                .WithOne(jobHistory => jobHistory.Job);
            modelBuilder.Entity<Job>()
                .HasMany<Employee>(job => job.Employees)
                .WithOne(employee => employee.Job);

            modelBuilder.Entity<Employee>()
                .Property(employee => employee.FirstName)
                .HasMaxLength(20);
            modelBuilder.Entity<Employee>()
                .Property(employee => employee.LastName)
                .HasMaxLength(25);
            modelBuilder.Entity<Employee>()
                .Property(employee => employee.Email)
                .HasMaxLength(25);
            modelBuilder.Entity<Employee>()
                .Property(employee => employee.PhoneNumber)
                .HasMaxLength(20);
            modelBuilder.Entity<Employee>()
                .HasMany<JobHistory>(employee => employee.JobHistories)
                .WithOne(jobHistory => jobHistory.Employee);

            modelBuilder.Entity<JobGrade>()
                .HasKey(jobGrade => jobGrade.GradeLevel);

            modelBuilder.Entity<JobHistory>()
                .HasKey(jobHistory => new { jobHistory.StartDate, jobHistory.EmployeeId });
        }
    }
}
