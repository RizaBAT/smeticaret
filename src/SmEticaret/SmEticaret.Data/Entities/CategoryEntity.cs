using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
    public class CategoryEntity : EntityBase
    {
        
        public string Name { get; set; } = string.Empty;
    }
}
