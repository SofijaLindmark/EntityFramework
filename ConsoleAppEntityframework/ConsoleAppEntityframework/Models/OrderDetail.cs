using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityframework.Models
{
   public class OrderDetail
    {
        public int Id { get; set; }
        public string Quantity { get; set; }
        public string ProductId { get; set; }

        public string OrderId { get; set; }

        public Orders Order { get; set; } = null!;

        public Products Product { get; set; } = null!;
    }
}
