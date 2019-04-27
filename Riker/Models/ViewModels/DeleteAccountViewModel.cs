using System;
using System.ComponentModel.DataAnnotations;

namespace riker.Models.ViewModels
{
    public class DeleteAccountViewModel
    {
        [Required]
        public string UserName { get; set; }
    }
}

