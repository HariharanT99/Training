using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Model
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
