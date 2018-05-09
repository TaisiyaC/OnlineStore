using System;
using System.Collections.Generic;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.EF;
using System.Data.Entity;

namespace OnlineStore.DAL.Repositories
{
    public class AddressRepository : IRepository<Address>
    {
        private ApplicationContext db;

        public AddressRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<Address> GetAll()
        {
            return db.Addresses;
        }

        public void Create(Address item)
        {
            db.Addresses.Add(item);
        }

        public Address Get(int id)
        {
            return db.Addresses.Find(id);
        }

        public void Update(Address item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Address Address = db.Addresses.Find(id);
            if (Address != null)
            {
                db.Entry(Address).State = EntityState.Deleted;
            }
        }
    }
}

