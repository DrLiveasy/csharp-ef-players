using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Entity_Framework_Players
{
    [Table("teams")]
    public class Team
    {
        #region Proprietà
        [Key]
        public int TeamId { get; set; }

        [Required]
        [Column("nome")]
        public string Name { get; set; }

        [Required]
        [Column("citta")]
        public string City { get; set; }

        [Required]
        [Column("allenatore")]
        public string Trainer { get; set; }

        
        List<Player> Players { get; set; }


        #endregion
    }
}
