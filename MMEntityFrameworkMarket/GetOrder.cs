using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEntityFrameworkMarket
{
    public class GetOrder
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        [MinLength(16)]
        public string CustomerCardNumber { get; set; }
        [MinLength(3)]
        public string CustomerCvc { get; set; }
        [MinLength(6)]
        public string CustomerCode { get; set; }
        public string CustomerOrderContent { get; set; }
    }
}
