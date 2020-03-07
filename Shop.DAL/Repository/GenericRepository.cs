using Microsoft.EntityFrameworkCore;
using Shop.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private ItemDbContext context;

        private DbSet<TEntity> dbSet;

        public GenericRepository(ItemDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return this.dbSet.ToList();
        }

        public virtual TEntity Get(int id)
        {
            return this.dbSet.Find(id);
        }

        public virtual void Delete(int id)
        {
            TEntity entityToDelete = this.dbSet.Find(id);
            this.Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entity)
        {
            if (this.context.Entry(entity).State == EntityState.Detached)
            {
                this.dbSet.Attach(entity);
            }
            this.dbSet.Remove(entity);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            this.dbSet.Attach(entityToUpdate);
            this.context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual void Add(TEntity entity)
        {
            this.dbSet.Add(entity);
        }
    }
}
