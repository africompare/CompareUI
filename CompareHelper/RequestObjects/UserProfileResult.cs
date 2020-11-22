using AfriCompare.Data.APIObjs;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace AfriCompare.Data.APIObjs
{
    public class UserProfileResult
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; } = Enumerable.Empty<string>();
        public string RefreshToken { get; set; }
        public ApplicationUser user { get; set; }
        public List<CompareRequestObj> Requests { get; set; }
        public string Role { get; set; }
    } 
}