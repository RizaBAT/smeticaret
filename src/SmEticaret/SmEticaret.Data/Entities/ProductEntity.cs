using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
    public class ProductEntity : EntityBase
    {
     
        public string Name { get; set; } = string.Empty;

       
        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int CategoryId { get; set; }

        
        public string ImageUrl { get; set; }

        public int SellerId { get; set; }

        
        public int PasswordHash { get; set; }

      
    }
}
