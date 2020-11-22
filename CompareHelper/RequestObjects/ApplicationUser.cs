using Microsoft.AspNetCore.Identity;

namespace AfriCompare.Data.APIObjs
{
    public class ApplicationUser : IdentityUser
    {
        public string Salutation { get; set; }
        public string FullName { get; set; }
        public int Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string City { get; set; }
    }
}