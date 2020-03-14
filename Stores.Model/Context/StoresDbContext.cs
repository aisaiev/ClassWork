using Microsoft.EntityFrameworkCore;
using Stores.Model.Entity.Production;
using Stores.Model.Entity.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Model.Context
{
    public class StoresDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Stores.Model.Entity.Sales.Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=StoresDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("staffs");
                entity.Property(entity => entity.StaffId)
                    .HasColumnName("staff_id");
                entity.Property(entity => entity.FirstName)
                    .HasColumnName("first_name");
                entity.Property(entity => entity.LastName)
                    .HasColumnName("last_name");
                entity.Property(entity => entity.Email)
                    .HasColumnName("email");
                entity.Property(entity => entity.Phone)
                    .HasColumnName("phone");
                entity.Property(entity => entity.Active)
                    .HasColumnName("active");
                entity.Property(entity => entity.StoreId)
                    .HasColumnName("store_id");
                entity.Property(entity => entity.ManagerId)
                    .HasColumnName("manager_id");
            });

            modelBuilder.Entity<Stores.Model.Entity.Sales.Store>(entity =>
            {
                entity.ToTable("stores");
                entity.Property(entity => entity.StoreId)
                    .HasColumnName("store_id");
                entity.Property(entity => entity.StoreName)
                   .HasColumnName("store_name");
                entity.Property(entity => entity.Phone)
                   .HasColumnName("phone");
                entity.Property(entity => entity.Email)
                   .HasColumnName("email");
                entity.Property(entity => entity.Street)
                   .HasColumnName("street");
                entity.Property(entity => entity.City)
                   .HasColumnName("city");
                entity.Property(entity => entity.State)
                   .HasColumnName("state");
                entity.Property(entity => entity.ZipCode)
                   .HasColumnName("zip_code");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");
                entity.Property(entity => entity.OrderId)
                    .HasColumnName("order_id");
                entity.Property(entity => entity.CustomerId)
                    .HasColumnName("customer_id");
                entity.Property(entity => entity.OrderStatus)
                    .HasColumnName("order_status");
                entity.Property(entity => entity.OrderDate)
                    .HasColumnName("order_date");
                entity.Property(entity => entity.RequiredDate)
                    .HasColumnName("required_date");
                entity.Property(entity => entity.ShippedDate)
                    .HasColumnName("shipped_date");
                entity.Property(entity => entity.StoreId)
                    .HasColumnName("store_id");
                entity.Property(entity => entity.StaffId)
                    .HasColumnName("staff_id");

                //
                // Fixed 'may cause cycles or multiple cascade path'.
                //
                entity.HasOne(order => order.Store)
                    .WithMany(store => store.Orders)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("order_itmes");
                entity.Property(entity => entity.OrderId)
                    .HasColumnName("order_id");
                entity.Property(entity => entity.ItemId)
                    .HasColumnName("item_id");
                entity.Property(entity => entity.ProductId)
                    .HasColumnName("product_id");
                entity.Property(entity => entity.Quantity)
                    .HasColumnName("quantity");
                entity.Property(entity => entity.ListPrice)
                    .HasColumnName("list_price");
                entity.Property(entity => entity.Discount)
                    .HasColumnName("discount");
            });
            modelBuilder.Entity<OrderItem>().HasKey(orderItem => new { orderItem.OrderId, orderItem.ItemId });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");
                entity.Property(entity => entity.CustomerId)
                    .HasColumnName("customer_id");
                entity.Property(entity => entity.FirstName)
                    .HasColumnName("first_name");
                entity.Property(entity => entity.LastName)
                    .HasColumnName("last_name");
                entity.Property(entity => entity.Phone)
                    .HasColumnName("phone");
                entity.Property(entity => entity.Email)
                    .HasColumnName("email");
                entity.Property(entity => entity.Street)
                    .HasColumnName("street");
                entity.Property(entity => entity.City)
                    .HasColumnName("city");
                entity.Property(entity => entity.State)
                    .HasColumnName("state");
                entity.Property(entity => entity.ZipCode)
                    .HasColumnName("zip_code");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("stocks");
                entity.Property(entity => entity.StoreId)
                    .HasColumnName("store_id");
                entity.Property(entity => entity.ProductId)
                    .HasColumnName("product_id");
                entity.Property(entity => entity.Quantity)
                    .HasColumnName("quantity");
            });
            modelBuilder.Entity<Stock>().HasKey(stock => new { stock.StoreId, stock.ProductId });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");
                entity.Property(entity => entity.ProductId)
                    .HasColumnName("product_id");
                entity.Property(entity => entity.ProductName)
                    .HasColumnName("product_name");
                entity.Property(entity => entity.BrandId)
                    .HasColumnName("brand_id");
                entity.Property(entity => entity.CategoryId)
                    .HasColumnName("category_id");
                entity.Property(entity => entity.ModelYear)
                    .HasColumnName("model_year");
                entity.Property(entity => entity.ListPrice)
                    .HasColumnName("list_price");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");
                entity.Property(entity => entity.CategoryId)
                    .HasColumnName("category_id");
                entity.Property(entity => entity.CategoryName)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("brands");
                entity.Property(entity => entity.BrandId)
                    .HasColumnName("brand_id");
                entity.Property(entity => entity.BrandName)
                    .HasColumnName("brand_name");
            });
        }
    }
}
