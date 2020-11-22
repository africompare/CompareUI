using System.Collections.Generic;
//using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AfriCompare.Data.APIObjs
{
    public class AuthFailedResponse //: ModelStateDictionary
    {
        public IEnumerable<string> Errors { get; set; }
    }
}