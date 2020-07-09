using System;
using System.Collections.Generic;

namespace ListofPOC.Models
{
    public partial class Class
    {
        public Class()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Class1 { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
