using System;
using System.Collections.Generic;

#nullable disable

namespace Presentation.Models
{
    public partial class Break
    {
        public int Id { get; set; }
        public int? EntryId { get; set; }
        public TimeSpan? BreakIn { get; set; }
        public TimeSpan? BreakOut { get; set; }

        public virtual Entry Entry { get; set; }
    }
}
