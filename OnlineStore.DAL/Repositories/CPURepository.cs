using System;
using System.Collections.Generic;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.EF;
using System.Data.Entity;

namespace OnlineStore.DAL.Repositories
{
    public class CPURepository : IRepository<CPU>
    {
        private ApplicationContext db;

        public CPURepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<CPU> GetAll()
        {
            return db.CPUs;
        }

        public void Create(CPU item)
        {
            db.CPUs.Add(item);
        }

        public CPU Get(int id)
        {
            return db.CPUs.Find(id);
        }

        public void Update(CPU item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            CPU CPU = db.CPUs.Find(id);
            if (CPU != null)
            {
                db.Entry(CPU).State = EntityState.Deleted;
            }
        }
    }
}
