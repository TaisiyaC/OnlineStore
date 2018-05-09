using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class Storage
    {
        public Storage()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StorageID { get; set; }

        public int RAM { get; set; }

        public int BuiltinMemory { get; set; }

        public int ContactsNumber { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
