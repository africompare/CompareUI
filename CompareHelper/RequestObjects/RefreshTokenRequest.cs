using System.ComponentModel.DataAnnotations;

namespace AfriCompare.Data.APIObjs
{
    public class RefreshTokenRequest
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string RefreshToken { get; set; }
    }
}