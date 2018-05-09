using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineStore.DAL.Entities
{
   public  class Order
    {
        public Order()
        {
            PreOrders = new HashSet<PreOrder>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        public DateTime DateOfOrder { get; set; }

        public DateTime DateOfDelivery { get; set; }

        public int OrderCost { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2000)]
        public string OrderNotice { get; set; }

        [ForeignKey("Payment")]
        public int? PaymentID { get; set; }

        public virtual Payment Payment { get; set; }

        public virtual ICollection<PreOrder> PreOrders { get; set; }
    }
}
