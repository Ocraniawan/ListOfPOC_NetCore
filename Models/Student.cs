using System;
using System.Collections.Generic;

namespace ListofPOC.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdClass { get; set; }
        public string Status { get; set; }

        public virtual Class IdClassNavigation { get; set; }
    }
}
