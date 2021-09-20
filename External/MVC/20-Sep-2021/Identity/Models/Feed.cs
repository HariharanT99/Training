using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class Feed
    {
        public string Property { get; set; }

        public string Comment { get; set; }

        public string Service { get; set; }
        public int Rating { get; set; }
        public int StarRating { get; set; }
    }
}
