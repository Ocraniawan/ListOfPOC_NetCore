using System;
using System.Collections.Generic;

namespace ListofPOC.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? IsNew { get; set; }
        public DateTime? IsUpdate { get; set; }
    }
}
