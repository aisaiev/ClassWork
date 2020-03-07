using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL.Model
{
    public class ItemDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=ShopDb;Trusted_Connection=True;");
        }
    }
}
