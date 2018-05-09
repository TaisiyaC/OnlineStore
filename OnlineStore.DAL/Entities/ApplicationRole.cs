using Microsoft.AspNet.Identity.EntityFramework;

namespace OnlineStore.DAL.Entities
{
    class ApplicationRole : IdentityRole
    {
        public ApplicationRole() { }
        public ApplicationRole(string name)
            : this()
        {
            this.Name = name;
        }

    }
}
