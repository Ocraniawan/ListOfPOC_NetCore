using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ListofPOC.Models
{
    [Table("CohiveQuantum")]
    public partial class Quantum
    {
        [Key]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }

        public int CohiveId { get; set; }
        public Cohive Cohive { get; set; }
    }
}
