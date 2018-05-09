using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class Dimension
    {
        public Dimension()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DimensionID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Height { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Width { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Length { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
