using System;
using System.Collections.Generic;

namespace ListofPOC.Models
{
    public partial class BookStudent
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
