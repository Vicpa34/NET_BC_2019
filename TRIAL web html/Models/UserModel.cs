using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace TRIAL_web_html.Models
{
    public class UserModel
        {
            [Required]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set;}
            [Required]
            [DataType(DataType.Password)]
            
            public string Password { get; set;}
            
            [Required]
            [DataType(DataType.EmailAddress)]
            [Compare("Password")]
            public string PasswordRepeat { get; set; }
        }
}
