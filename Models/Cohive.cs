using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ListofPOC.Models
{
    [Table("Simas")]
    public partial class Cohive
    {
        [Key]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }

        public ICollection<Quantum> Quantum { get; set; }
    }
}
