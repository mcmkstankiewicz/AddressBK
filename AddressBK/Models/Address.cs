using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBK.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica:")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Pole jest wymagane")]
        public string Street { get; set; }
        [Display(Name = "jej numer:")]
        public int Number { get; set; }
        [Display(Name = "i kod pocztowy:")]
        public string ZipCode { get; set; }
        [Display(Name = "Znajduje się w mieście:")]
        public string City { get; set; }
    }
}
