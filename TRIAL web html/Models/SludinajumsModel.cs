using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TRIAL_web_html.Models
{
    public class SludinajumsModel
    {
        [Required]
        public int Id { get; set; }
        [Required] 
        public int CategoryId { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [MaxLength(20)]
        public string Place { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        public string Photo { get; set; }

    }
}
