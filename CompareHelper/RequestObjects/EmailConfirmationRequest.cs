using System.ComponentModel.DataAnnotations;

namespace AfriCompare.Data.APIObjs
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