using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
