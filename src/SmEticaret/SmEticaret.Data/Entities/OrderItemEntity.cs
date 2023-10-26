using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
    public class OrderItemEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
       
        public int Quantity { get; set; }

        
        public decimal Paid { get; set; }
    }
}
