using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContext QuickBuyContext;

        public BaseRepository(QuickBuyContext quickBuyContext)
        {
            QuickBuyContext = quickBuyContext;
        }

        public void Add(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Add(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            QuickBuyContext.Remove(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Dispose()
        {
            /// To discard the object from memory
            QuickBuyContext.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return QuickBuyContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return QuickBuyContext.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Update(entity);
            QuickBuyContext.SaveChanges();
        }
    }
}
