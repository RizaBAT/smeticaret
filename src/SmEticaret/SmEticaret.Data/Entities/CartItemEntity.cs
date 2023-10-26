using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
    public class CartItemEntity : EntityBase
    {
        public int CartId { get; set; } 
        public int ProductId { get; set; }
       
        public int Quantity { get; set; }
    }
}
