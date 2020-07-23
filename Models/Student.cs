using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ListofPOC.Models
{
    public partial class Student
    { 
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public IList<BookStudent> BookStudents { get; set; }

        public Address Address { get; set; }
    }
}
