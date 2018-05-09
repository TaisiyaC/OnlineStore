using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("OnlineStore") { }
        public ApplicationContext(string connectionString) : base(connectionString) { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Navigation> Navigations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PhoneDiagonal> PhoneDiagonals { get; set; }
        public DbSet<Preferences> Preferences{ get; set; }
        public DbSet<PreOrder> PreOrders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SIM> SIMs { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<TypeSIM> TypeSIMs { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ApplicationContext>(null);
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
            base.OnModelCreating(modelBuilder);
        }
        static ApplicationContext()
        {
            Database.SetInitializer<ApplicationContext>(new IdentityDbInit());
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

    }

    public class IdentityDbInit : DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            PerformInitialSetup(context);
            base.Seed(context);
        }
        public void PerformInitialSetup(ApplicationContext context)
        {
            // настройки конфигурации контекста будут указываться здесь
        }
    }
}

