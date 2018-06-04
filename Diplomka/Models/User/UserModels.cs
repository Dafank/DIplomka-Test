using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace Diplomka.Models.User
{
    public class UserContext: DbContext
    {
        public UserContext() : base("DefaultConnection") { }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

    public class LoginModel
    {
        [Required(ErrorMessage = "You have not entered the email")]
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email address is not correct")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You have not entered the password")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "You must specify a password between 5 and 20 characters")]
        public string Password { get; set; }
    }

    public class RegistrationModel
    {
        [Required(ErrorMessage = "You have not entered the email")]
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email address is not correct")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You have not entered the password")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "You must specify a password between 5 and 20 characters")]
        [Compare("PasswordConfirm", ErrorMessage = "Passwords do not match")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password:")]
        [Required(ErrorMessage = "You have not entered confirm password")]
        public string PasswordConfirm { get; set; }
    }

}