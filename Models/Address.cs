using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ListofPOC.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Column("Address")]
        public string Address1 { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
