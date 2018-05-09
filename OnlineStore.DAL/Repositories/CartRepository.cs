using System;
using System.Collections.Generic;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.EF;
using System.Data.Entity;

namespace OnlineStore.DAL.Repositories
{
    public class CartRepository : IRepository<Cart>
    {
        private ApplicationContext db;

        public CartRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<Cart> GetAll()
        {
            return db.Carts;
        }

        public void Create(Cart item)
        {
            db.Carts.Add(item);
        }

        public Cart Get(int id)
        {
            return db.Carts.Find(id);
        }

        public void Update(Cart item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Cart Cart = db.Carts.Find(id);
            if (Cart != null)
            {
                db.Entry(Cart).State = EntityState.Deleted;
            }
        }
    }
}
