using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class Navigation
    {
        public Navigation()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NavigationID { get; set; }

        public bool GPS { get; set; }

        public bool AGPS { get; set; }

        public bool Beidou { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
