using System;
using System.ComponentModel.DataAnnotations;

namespace riker.Models.ViewModels
{
    public class ChangeEmailViewModel
    {
        [Required]
        public string ConfirmedEmail { get; set; }
        [Required]
        public string UnConfirmedEmail { get; set; }
    }
}