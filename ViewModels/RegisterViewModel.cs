﻿using System.ComponentModel.DataAnnotations;

namespace MVCapp.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and maz {1} character long.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage= "Password does not match")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirming password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
