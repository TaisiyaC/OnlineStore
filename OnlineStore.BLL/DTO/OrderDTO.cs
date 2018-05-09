using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BLL.DTO
{
    public class OrderDTO
    {
        public int OrderID { get; set; }

        public DateTime DateOfOrder { get; set; }

        public DateTime DateOfDelivery { get; set; }

        public int OrderCost { get; set; }

        public string OrderNotice { get; set; }
    }
}
