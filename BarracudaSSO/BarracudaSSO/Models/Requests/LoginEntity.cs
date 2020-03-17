using System;
using System.ComponentModel.DataAnnotations;


namespace BarracudaSSO.Models.Requests
{
    public class LoginEntity
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
