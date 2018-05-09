using System;
using System.Collections.Generic;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.EF;
using System.Data.Entity;

namespace OnlineStore.DAL.Repositories
{
    public class PreOrderRepository : IRepository<PreOrder>
    {
        private ApplicationContext db;

        public PreOrderRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<PreOrder> GetAll()
        {
            return db.PreOrders;
        }

        public void Create(PreOrder item)
        {
            db.PreOrders.Add(item);
        }

        public PreOrder Get(int id)
        {
            return db.PreOrders.Find(id);
        }

        public void Update(PreOrder item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            PreOrder PreOrder = db.PreOrders.Find(id);
            if (PreOrder != null)
            {
                db.Entry(PreOrder).State = EntityState.Deleted;
            }
        }
    }
}
