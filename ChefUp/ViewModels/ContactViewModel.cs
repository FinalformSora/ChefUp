using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefUp.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(350, ErrorMessage = "Your message is too long! Shorten it bruh!")]
        public string Message { get; set; }
    }
}
