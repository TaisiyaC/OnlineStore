using System;
using System.Collections.Generic;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.EF;
using System.Data.Entity;
using System.Threading.Tasks;

namespace OnlineStore.DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private ApplicationContext db;

        public ProductRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public void Create(Product item)
        {
            db.Products.Add(item);
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public void Update(Product item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product Product = db.Products.Find(id);
            if (Product != null)
            {
                db.Entry(Product).State = EntityState.Deleted;
            }
        }
    }
}
