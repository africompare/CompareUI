using System.Collections.Generic;
using System.Text;

namespace ApiHandshake
{
    class ApiRequests
    {
        private readonly string baseUrl;

        public ApiRequests()
        {
            baseUrl = "https://services.africompare.com";
        }
         
        public string GetBaseUrl()
        {
            return baseUrl;
        }
    }
}
