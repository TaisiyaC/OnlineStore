using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class PreOrder
    {
        public PreOrder()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PreOrderID { get; set; }

        public int Amount { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int? ProductID { get; set; }

        [Required]
        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }

        [ForeignKey("Order")]
        public string OrderID { get; set; }

        [ForeignKey("Cart")]
        public string CartID { get; set; }

        public virtual Product Products { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Order Order { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
