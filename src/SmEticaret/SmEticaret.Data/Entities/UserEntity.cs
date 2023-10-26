using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
    public class UserEntity : EntityBase
    {
        public int RoleId { get; set; }
       
        public string Name { get; set; } = string.Empty;
      
        public string LastName { get; set; } = string.Empty;
       
        public string Email { get; set; } = string.Empty;
        
        public string PasswordHash { get; set; }

       
        public RoleEntity Role { get; set; }
    }
}
