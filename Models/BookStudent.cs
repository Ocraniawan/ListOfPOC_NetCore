using System;
using System.Collections.Generic;

namespace ListofPOC.Models
{
    public partial class BookStudent
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public int? StudentId { get; set; }
    }
}
