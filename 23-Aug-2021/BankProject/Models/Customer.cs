using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        [StringLength(20, ErrorMessage = "Name can not exceed 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "The Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "The Minimum Balance is required")]
        [Range(500,100000,ErrorMessage ="Minimum balance Rs.500 is Required")]
        [DisplayName("Opening Balance")]
        public double OpeningBalance { get; set; }
    }
}
