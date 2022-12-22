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
        public int Team_id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Trainer { get; set; }

        public List<Player> Players { get; set;}


        #endregion
    }
}
