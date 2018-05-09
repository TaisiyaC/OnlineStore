using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
   public class Material
    {
        public Material()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string ProductMaterial { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
