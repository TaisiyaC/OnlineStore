using OnlineStore.DAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using OnlineStore.DAL.EF;

namespace OnlineStore.DAL.Identity
{
    public class ApplicationRoleManager : RoleManager<ApplicationRole>
    {
        public ApplicationRoleManager(RoleStore<ApplicationRole> store)
                   : base(store)
        {
        }
        public static ApplicationRoleManager Create(
           IdentityFactoryOptions<ApplicationRoleManager> options,
           IOwinContext context)
        {
            return new ApplicationRoleManager(new
                RoleStore<ApplicationRole>(context.Get<ApplicationContext>()));
        }
    }
}
