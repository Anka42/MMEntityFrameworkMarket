using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEntityFrameworkMarket
{
    public class Order
    {
        public int id { get; set; }
        public string OrderName { get; set; }
        public int OrderAmount { get; set; }
        public decimal OrderPrice { get; set; }
        public string OrderStatus { get; set; }

    }
}
