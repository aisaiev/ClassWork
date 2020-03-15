using Microsoft.EntityFrameworkCore;
using Stores.Model.Entity.Production;
using Stores.Model.Entity.Sales;
using System;

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


            Brand brand1 = new Brand { BrandId = 1, BrandName = "Electra" };
            Brand brand2 = new Brand { BrandId = 2, BrandName = "Haro" };
            Brand brand3 = new Brand { BrandId = 3, BrandName = "Heller" };
            Brand brand4 = new Brand { BrandId = 4, BrandName = "Pure Cycles" };
            Brand brand5 = new Brand { BrandId = 5, BrandName = "Ritchey" };
            Brand[] brands = { brand1, brand2, brand3, brand4, brand5 };
            modelBuilder.Entity<Brand>().HasData(brands);

            Category category1 = new Category { CategoryId = 1, CategoryName = "Children Bicycles" };
            Category category2 = new Category { CategoryId = 2, CategoryName = "Comfort Bicycles" };
            Category category3 = new Category { CategoryId = 3, CategoryName = "Cruisers Bicycles" };
            Category category4 = new Category { CategoryId = 4, CategoryName = "Cyclocross Bicycles" };
            Category category5 = new Category { CategoryId = 5, CategoryName = "Electric Bikes" };
            Category category6 = new Category { CategoryId = 6, CategoryName = "Mountain Bikes" };
            Category[] categories = { category1, category2, category3, category4, category5, category6 };
            modelBuilder.Entity<Category>().HasData(categories);

            Product product1 = new Product { ProductId = 1, ProductName = "Electra Townie Original 21D - 2016", BrandId = 1, CategoryId = 3, ModelYear = new DateTime(2016, 1, 1), ListPrice = 550 };
            Product product2 = new Product { ProductId = 2, ProductName = "Pure Cycles Vine 8-Speed - 2016", BrandId = 4, CategoryId = 3, ModelYear = new DateTime(2016, 1, 1), ListPrice = 430 };
            Product product3 = new Product { ProductId = 3, ProductName = "Haro Downtown 16 - 2017", BrandId = 2, CategoryId = 1, ModelYear = new DateTime(2017, 1, 1), ListPrice = 330 };
            Product product4 = new Product { ProductId = 4, ProductName = "Haro Shredder 20 - 2017", BrandId = 2, CategoryId = 1, ModelYear = new DateTime(2017, 1, 1), ListPrice = 210 };
            Product product5 = new Product { ProductId = 5, ProductName = "Ritchey Timberwolf Frameset - 2016", BrandId = 5, CategoryId = 6, ModelYear = new DateTime(2016, 1, 1), ListPrice = 380 };
            Product[] products = { product1, product2, product3, product4, product5 };
            modelBuilder.Entity<Product>().HasData(products);

            Stock stock1 = new Stock { StoreId = 1, ProductId = 1, Quantity = 5 };
            Stock stock2 = new Stock { StoreId = 1, ProductId = 2, Quantity = 15 };
            Stock stock3 = new Stock { StoreId = 1, ProductId = 3, Quantity = 20 };
            Stock stock4 = new Stock { StoreId = 1, ProductId = 4, Quantity = 1 };
            Stock stock5 = new Stock { StoreId = 1, ProductId = 5, Quantity = 10 };
            Stock[] stocks = { stock1, stock2, stock3, stock4, stock5 };
            modelBuilder.Entity<Stock>().HasData(stocks);

            Customer customer1 = new Customer { CustomerId = 1, FirstName = "Debra", LastName = "Burks", Phone = "(516) 583-7761", Email = "debra.burks@yahoo.com", Street = "9273 Thorne Ave.", City = "Orchard Park", State = "NY", ZipCode = "14127" };
            Customer customer2 = new Customer { CustomerId = 2, FirstName = "Kasha", LastName = "Todd", Phone = "(212) 945-8823", Email = "kasha.todd@yahoo.com", Street = "910 Vine Street", City = "Campbell", State = "CA", ZipCode = "95008" };
            Customer customer3 = new Customer { CustomerId = 3, FirstName = "Tameka", LastName = "Fisher", Phone = "(562) 215-2907", Email = "tameka.fisher@aol.com", Street = "769C Honey Creek St.", City = "Redondo Beach", State = "CA", ZipCode = "90278" };
            Customer customer4 = new Customer { CustomerId = 4, FirstName = "Daryl", LastName = "Spence", Phone = "(510) 246-8375", Email = "daryl.spence@aol.com", Street = "988 Pearl Lane", City = "Uniondale", State = "NY", ZipCode = "11553" };
            Customer customer5 = new Customer { CustomerId = 5, FirstName = "Charolette", LastName = "Rice", Phone = "(916) 381-6003", Email = "charolette.rice@msn.com", Street = "107 River Dr.", City = "Sacramento", State = "CA", ZipCode = "95820" };
            Customer[] customers = { customer1, customer2, customer3, customer4, customer5 };
            modelBuilder.Entity<Customer>().HasData(customers);

            OrderItem orderItem1 = new OrderItem { OrderId = 1, ItemId = 1, ProductId = 1, Quantity = 1, ListPrice = 600, Discount = 0.2 };
            OrderItem orderItem2 = new OrderItem { OrderId = 1, ItemId = 2, ProductId = 3, Quantity = 2, ListPrice = 860, Discount = 0.07 };
            OrderItem orderItem3 = new OrderItem { OrderId = 2, ItemId = 3, ProductId = 2, Quantity = 1, ListPrice = 330, Discount = 0.2 };
            OrderItem orderItem4 = new OrderItem { OrderId = 3, ItemId = 4, ProductId = 4, Quantity = 1, ListPrice = 210, Discount = 0.2 };
            OrderItem orderItem5 = new OrderItem { OrderId = 4, ItemId = 5, ProductId = 5, Quantity = 1, ListPrice = 380, Discount = 0.2 };
            OrderItem orderItem6 = new OrderItem { OrderId = 5, ItemId = 5, ProductId = 5, Quantity = 1, ListPrice = 380, Discount = 0.2 };
            OrderItem[] orderItems = { orderItem1, orderItem2, orderItem3, orderItem4, orderItem5, orderItem6 };
            modelBuilder.Entity<OrderItem>().HasData(orderItems);

            Order order1 = new Order { OrderId = 1, CustomerId = 1, OrderStatus = "Shipped", OrderDate = new DateTime(2016, 1, 1), RequiredDate = new DateTime(2016, 1, 3), ShippedDate = new DateTime(2016, 1, 3), StoreId = 1, StaffId = 1 };
            Order order2 = new Order { OrderId = 2, CustomerId = 2, OrderStatus = "Shipped", OrderDate = new DateTime(2016, 1, 1), RequiredDate = new DateTime(2016, 1, 4), ShippedDate = new DateTime(2016, 1, 3), StoreId = 1, StaffId = 1 };
            Order order3 = new Order { OrderId = 3, CustomerId = 3, OrderStatus = "Shipped", OrderDate = new DateTime(2016, 1, 2), RequiredDate = new DateTime(2016, 1, 5), ShippedDate = new DateTime(2016, 1, 3), StoreId = 1, StaffId = 2 };
            Order order4 = new Order { OrderId = 4, CustomerId = 4, OrderStatus = "Shipped", OrderDate = new DateTime(2016, 1, 3), RequiredDate = new DateTime(2016, 1, 4), ShippedDate = new DateTime(2016, 1, 5), StoreId = 1, StaffId = 2 };
            Order order5 = new Order { OrderId = 5, CustomerId = 5, OrderStatus = "Shipped", OrderDate = new DateTime(2016, 1, 3), RequiredDate = new DateTime(2016, 1, 5), ShippedDate = new DateTime(2016, 1, 6), StoreId = 1, StaffId = 3 };
            Order[] orders = { order1, order2, order3, order4, order5 };
            modelBuilder.Entity<Order>().HasData(orders);

            Staff staff1 = new Staff { StaffId = 1, FirstName = "Fabiola", LastName = "Jackson", Email = "fabiola.jackson@bikes.shop", Phone = "(831) 555-5554", Active = true, StoreId = 1 };
            Staff staff2 = new Staff { StaffId = 2, FirstName = "Mireya", LastName = "Copeland", Email = "mireya.copeland@bikes.shop", Phone = "(831) 555-5555", Active = true, StoreId = 1, ManagerId = 1 };
            Staff staff3 = new Staff { StaffId = 3, FirstName = "Genna", LastName = "Serrano", Email = "genna.serrano@bikes.shop", Phone = "(831) 555-5556", Active = true, StoreId = 1, ManagerId = 1 };
            Staff[] staffs = { staff1, staff2, staff3 };
            modelBuilder.Entity<Staff>().HasData(staffs);

            Stores.Model.Entity.Sales.Store store = new Stores.Model.Entity.Sales.Store() { StoreId = 1, StoreName = "Santa Cruz Bikes", Phone = "(831) 476-4321", Email = "santacruz@bikes.shop", Street = "3700 Portola Drive", City = "Santa Cruz", State = "CA", ZipCode = "95060" };
            Stores.Model.Entity.Sales.Store[] stores = { store };
            modelBuilder.Entity<Stores.Model.Entity.Sales.Store>().HasData(stores);
        }
    }
}
