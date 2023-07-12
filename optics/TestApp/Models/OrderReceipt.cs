using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    class OrderReceipt:Order
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string Employee { get; set; }
        public List<OrderItem> items { get; set; }
    }
}
