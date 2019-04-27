﻿using System;
using System.ComponentModel.DataAnnotations;

namespace riker.Models.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
