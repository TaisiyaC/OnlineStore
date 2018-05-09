using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.DAL.Entities
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        [Column(TypeName = "nvarchar")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string LastName { get; set; }

        public DateTime DoB { get; set; }
                    
    }
}
