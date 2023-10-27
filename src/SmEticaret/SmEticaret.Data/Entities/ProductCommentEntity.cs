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

        [Required, MaxLength(250)]
        public string Message { get; set; } = string.Empty;

        [Required, Range(1, 5)]
        public byte StarCount { get; set; }

        [Required]
        public DateTime CreateAd { get; set; }
    }
}
