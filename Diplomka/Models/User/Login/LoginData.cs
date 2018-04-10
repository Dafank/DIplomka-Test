using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Diplomka.Models.User.Login
{
    public class LoginData
    {
        [Required(ErrorMessage = "You have not entered the email")]
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email address is not correct")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You have not entered the password")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "You must specify a password between 5 and 20 characters")]
        public string Password { get; set; }
    }
}