using System;
using System.Collections.Generic;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.EF;
using System.Data.Entity;

namespace OnlineStore.DAL.Repositories
{
   public class PreferencesRepository : IRepository<Preferences>
    {
        private ApplicationContext db;

        public PreferencesRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<Preferences> GetAll()
        {
            return db.Preferences;
        }

        public void Create(Preferences item)
        {
            db.Preferences.Add(item);
        }

        public Preferences Get(int id)
        {
            return db.Preferences.Find(id);
        }

        public void Update(Preferences item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Preferences Preferences = db.Preferences.Find(id);
            if (Preferences != null)
            {
                db.Entry(Preferences).State = EntityState.Deleted;
            }
        }
    }
}
