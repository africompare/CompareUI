using System.ComponentModel.DataAnnotations;

namespace AfriCompare.API.Controllers
{
    public class UserRegistrationRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}