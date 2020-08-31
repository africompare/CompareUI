using System.ComponentModel.DataAnnotations;

namespace AfriCompare.API.Controllers
{
    public class ResetPasswordRequest
    {
        [Required]
       // [EmailAddress]
        public string Email { get; set; }
    }
}