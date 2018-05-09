using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
   public class SIM
    {
        public SIM()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SimlID { get; set; }

        [ForeignKey("TypeSIM")]
        public int? TypeSimID { get; set; }

        public int SIMNumber { get; set; }

        public bool Support3G { get; set; }

        public bool Support4G { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual TypeSIM TypeSIM { get; set; }
    }


}
