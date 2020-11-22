using System.ComponentModel.DataAnnotations;

namespace AfriCompare.Data.APIObjs
{
    public class ResetPasswordRequest
    {
        [Required]
       // [EmailAddress]
        public string Email { get; set; }
    }
}