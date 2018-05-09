using System;
using System.Collections.Generic;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.EF;
using System.Data.Entity;

namespace OnlineStore.DAL.Repositories
{
    public class CameraRepository : IRepository<Camera>
    {
        private ApplicationContext db;

        public CameraRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<Camera> GetAll()
        {
            return db.Cameras;
        }

        public void Create(Camera item)
        {
            db.Cameras.Add(item);
        }

        public Camera Get(int id)
        {
            return db.Cameras.Find(id);
        }

        public void Update(Camera item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Camera Camera = db.Cameras.Find(id);
            if (Camera != null)
            {
                db.Entry(Camera).State = EntityState.Deleted;
            }
        }
    }
}
