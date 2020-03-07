using Shop.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL.Repository
{
    public class UnitOfWork : IDisposable
    {
        private bool disposed;

        private ItemDbContext context;

        private GenericRepository<Item> itemRepository;

        public GenericRepository<Item> ItemRepository
        {
            get
            {
                if (this.itemRepository == null)
                {
                    this.itemRepository = new GenericRepository<Item>(this.context);
                }
                return this.itemRepository;
            }
        }

        public UnitOfWork()
        {
            this.context = new ItemDbContext();
            this.disposed = false;
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
