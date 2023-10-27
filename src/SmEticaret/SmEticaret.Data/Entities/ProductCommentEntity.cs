using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
    public class ProductCommentEntity
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }

      
        public string Message { get; set; } = string.Empty;

        
        public byte StarCount { get; set; }
       
        public DateTime CreateAd { get; set; }
    }
}
