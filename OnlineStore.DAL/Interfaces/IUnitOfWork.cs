using OnlineStore.DAL.Identity;
using System;
using System.Threading.Tasks;
using OnlineStore.DAL.Entities;
using System.Collections.Generic;
using OnlineStore.DAL.Repositories;

namespace OnlineStore.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationUserManager UserManager { get; }
        ApplicationRoleManager RoleManager { get; }
        IRepository<Address> Address { get; }
        IRepository<Camera> Camera { get; }
        IRepository<Cart> Cart { get; }
        IRepository<CPU> CPU { get; }
        IRepository<Order> Order { get; }
        IRepository<Preferences> Preferences { get; }
        IRepository<PreOrder> PreOrder { get; }
        IRepository<Product> Product { get; }
        Task SaveAsync();
        void Save();
    }
}
