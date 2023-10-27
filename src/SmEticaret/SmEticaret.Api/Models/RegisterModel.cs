using System.ComponentModel.DataAnnotations;

namespace SmEticaret.Api.Controllers
{
    public class RegisterModel
    {
        public int RoleId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MinLength(1)]
        public string Password { get; set; }
    }
}
