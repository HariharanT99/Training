using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class CreateRoleViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
