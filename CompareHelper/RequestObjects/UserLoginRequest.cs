﻿using System.ComponentModel.DataAnnotations;

namespace AfriCompare.API.Controllers
{
    public class UserLoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get;  set; }
        [Required]
        public string Password { get;  set; }
    }
}