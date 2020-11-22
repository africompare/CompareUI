﻿using System.ComponentModel.DataAnnotations;

namespace AfriCompare.Data.APIObjs
{
    public class RefreshTokenRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; internal set; }
        [Required]
        public string Password { get; internal set; }
    }
}