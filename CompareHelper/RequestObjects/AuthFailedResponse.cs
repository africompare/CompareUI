using System.Collections.Generic;
//using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AfriCompare.API.Controllers
{
    public class AuthFailedResponse //: ModelStateDictionary
    {
        public IEnumerable<string> Errors { get; set; }
    }
}