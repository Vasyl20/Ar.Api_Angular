using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AR.DTO.Results
{
    public class UserRegister
    {
        [Required(ErrorMessage = "Email is required filds")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Passwprd is required filds")]
        public string Passwprd { get; set; }

        [Required(ErrorMessage = "Full name is required filds")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Phone is required filds")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is required filds")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Age is required filds")]
        public string Age { get; set; }
    }
}
