using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class EntryViewModel
    {

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        public string EmployeeId { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }
        [Column(TypeName = "datetime")]

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "InTime is required")]
        public TimeSpan? InTime { get; set; }
        [Column(TypeName = "datetime")]

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "OutTime is required")]
        public TimeSpan? OutTime { get; set; }

        public List<Break> BreakList { get; set; } = new List<Break>();
    }
}
