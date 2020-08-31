using System;
using System.Collections.Generic;
using System.Text;

namespace AfriCompare.Data.APIObjects
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public TimeSpan TokenLifetime { get; set; } 
    }
}
