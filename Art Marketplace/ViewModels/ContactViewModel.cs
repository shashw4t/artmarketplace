﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Marketplace.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Please limit your message to 250 characters.")]
        public string Message { get; set; }
    }
}
