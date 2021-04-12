using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AR.DTO.Results
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "Email is required filds")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Passwprd is required filds")]
        public string Passwprd { get; set; }
    }
}
