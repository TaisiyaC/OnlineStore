using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class Cart
    {
        public Cart()
        {
            PreOrders = new HashSet<PreOrder>();
        }
   

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartID { get; set; }

        public int FinalCost { get; set; }

        public DateTime DateOfAdding { get; set; }

        public virtual ICollection<PreOrder> PreOrders { get; set; }
    }
}
