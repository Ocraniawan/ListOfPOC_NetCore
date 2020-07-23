using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ListofPOC.Models
{
    public partial class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public IList<BookStudent> BookStudents { get; set; }
    }
}
