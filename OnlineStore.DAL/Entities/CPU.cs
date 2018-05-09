using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class CPU
    {
           public CPU()
            {
                Products = new HashSet<Product>();
            }

            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int CpuID { get; set; }

            [Column(TypeName = "nvarchar")]
            [StringLength(50)]
            public string CPUName { get; set; }

            public int CoresNumber { get; set; }
        
            public virtual ICollection<Product> Products { get; set; }
        }
}
