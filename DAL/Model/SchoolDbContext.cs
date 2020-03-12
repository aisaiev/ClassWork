using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<StudentAddress> StudentAddress { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=SchoolDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany<Book>(student => student.Books)
                .WithOne(book => book.Student);

            modelBuilder.Entity<Student>()
                .HasOne<StudentAddress>(student => student.Address)
                .WithOne(address => address.Student);
        }
    }
}
