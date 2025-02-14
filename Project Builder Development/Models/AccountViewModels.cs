﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Project_Builder_Development.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "UserId")]
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }

    public class RegisterViewModel
    {

        [Required]
        [StringLength(25, ErrorMessage = "UserId must be {2} to {0} characters long.", MinimumLength = 3)]
        [Display(Name = "UserId")]
        [Index(IsUnique = true)]
        public string UserId { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Password must be {2} to {0} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "First Name must be {2} to {0} characters long.", MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Last Name must be atleast {2} characters long.", MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "Email address must be atleast {2} characters long.", MinimumLength = 3)]
        [Display(Name = "Email Address")]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Roles: ")]
        public IEnumerable<string> Roles { get; set; }  
    }

    public class RegisterFormViewModel {

        [Required]
        [StringLength(25, ErrorMessage = "UserId must be {2} to {0} characters long.", MinimumLength = 3)]
        [Display(Name = "UserId")]
        [Index(IsUnique = true)]
        public string UserId { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Password must be {2} to {0} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "First Name must be {2} to {0} characters long.", MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Last Name must be atleast {2} characters long.", MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "Email address must be atleast {2} characters long.", MinimumLength = 3)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        public MultiSelectList RoleList { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class AccountDetails
    {
        [Display(Name = "User (login) name")]
        public string UserName { get; set; }

        [Display(Name = "Internal name")]
        public string ClaimsName { get; set; }

        [Display(Name = "Given (first) name(s)")]
        public string ClaimsGivenName { get; set; }

        [Display(Name = "Surname (family name)")]
        public string ClaimsSurname { get; set; }

        [Display(Name = "Email address")]
        public string ClaimsEmail { get; set; }

        [Display(Name = "Roles")]
        public string ClaimsRoles { get; set; }
    }

    public class RegisterEdit
    {
        [Key]
        public string UserId { get; set; }

        public string UserName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "First Name must be {2} to {0} characters long.", MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Last Name must be atleast {2} characters long.", MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
