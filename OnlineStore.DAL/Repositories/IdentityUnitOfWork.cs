using OnlineStore.DAL.EF;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;
using OnlineStore.DAL.Identity;
using System.Collections.Generic;

namespace OnlineStore.DAL.Repositories
{
    public class IdentityUnitOfWork : IUnitOfWork
    {
        private ApplicationContext db;

        private ApplicationUserManager userManager;
        private ApplicationRoleManager roleManager;
        private IRepository<Address> addressRepository;
        private IRepository<Camera> cameraRepository;
        private IRepository<Cart> cartRepository;
        private IRepository<CPU> cpuRepository;
        private IRepository<Order> orderRepository;
        private IRepository<Preferences> preferencesRepository;
        private IRepository<PreOrder> preOrderRepository;
        private IRepository<Product> productRepository;



        public IdentityUnitOfWork(string connectionString)
        {
            db = new ApplicationContext(connectionString);
            userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
            roleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(db));
        }

        public IRepository<Address> Address
        {
            get
            {
                if (addressRepository == null)
                    addressRepository = new AddressRepository(db);
                return addressRepository;
            }
        }
        public IRepository<Camera> Camera
        {
            get
            {
                if (cameraRepository == null)
                    cameraRepository = new CameraRepository(db);
                return cameraRepository;
            }
        }
        public IRepository<Cart> Cart
        {
            get
            {
                if (cartRepository == null)
                    cartRepository = new CartRepository(db);
                return cartRepository;
            }
        }
        public IRepository<CPU> CPU
        {
            get
            {
                if (cpuRepository == null)
                    cpuRepository = new CPURepository(db);
                return cpuRepository;
            }
        }
        public IRepository<Order> Order
        {
            get
            {
                if (orderRepository == null)
                   orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }       
        public IRepository<Preferences> Preferences
        {
            get
            {
                if (preferencesRepository == null)
                    preferencesRepository = new PreferencesRepository(db);
                return preferencesRepository;
            }
        }
        public IRepository<PreOrder> PreOrder
        {
            get
            {
                if (preOrderRepository == null)
                    preOrderRepository = new PreOrderRepository(db);
                return preOrderRepository;
            }
        }
        public IRepository<Product> Product
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }
        
        public ApplicationUserManager UserManager
        {
            get { return userManager; }
        }
        
        public ApplicationRoleManager RoleManager
        {
            get { return roleManager; }

        }

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    userManager.Dispose();
                    roleManager.Dispose();
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
    }
}
