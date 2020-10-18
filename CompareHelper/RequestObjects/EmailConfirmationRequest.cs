using System.ComponentModel.DataAnnotations;

namespace AfriCompare.API.Controllers
{
    public class EmailConfirmationRequest
    {
        public EmailConfirmationRequest()
        {
        }

        [Required]
        public string UserId { get; set; }
        [Required]
        public string Token { get; set; } 
    }
}