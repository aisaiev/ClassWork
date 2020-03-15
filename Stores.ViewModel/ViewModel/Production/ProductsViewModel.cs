using Microsoft.EntityFrameworkCore;
using Store.Model.Context;
using Stores.Model.Entity.Production;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Stores.ViewModel.ViewModel.Production
{
    public class ProductsViewModel
    {
        public ObservableCollection<Product> Products { get; private set; }

        public Product SelectedProduct { get; set; }

        public ProductsViewModel()
        {
            this.GetAllProducts();
        }

        private void GetAllProducts()
        {
            using var context = new StoresDbContext();
            List<Product> products = context.Products
                .Include(product => product.Brand)
                .Include(product => product.Category)
                .Include(product => product.Stocks)
                .ThenInclude(stocks => stocks.Store)
                .ToList();
            this.Products = new ObservableCollection<Product>(products);
        }
    }
}
