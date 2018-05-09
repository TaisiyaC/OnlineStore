using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class PhoneDiagonal
    {
        public PhoneDiagonal()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiagonalID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Diagonal { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
