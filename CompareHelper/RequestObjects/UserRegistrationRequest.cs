﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AfriCompare.API.Controllers
{
    public class UserRegistrationRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required] 
        public string Password { get; set; }
        [Required] 
        public string ConfirmPassword { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Salutation { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string ConfirmationLink { get; set; }
    }
}