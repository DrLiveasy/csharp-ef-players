using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Entity_Framework_Players
{
    [Table("players")]
    public class Player
    {
        #region Proprietà

        [Key]
        public int PlayerId { get; set; }

        [Required]
        [Column("nome")]
        public string Name { get; set; }

        [Required]
        [Column("cognome")]
        public string Surname { get; set; }

        [Required]
        [Column("punteggio")]
        public double Punteggio { get; set; }

        [Required]
        [Column("partite_giocate")]
        public int partiteGiocate { get; set; }

        [Required]
        [Column("partite_vinte")]
        public int partiteVinte { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }




        #endregion

        #region Metodi

        public override string ToString()
        {
            return @$"---Dati Giocatore---
Nome: {this.Name}
Cognome: {this.Surname}
Punteggio: {this.Punteggio}
Partite Giocate: {this.partiteGiocate}
Partite Vinte: {this.partiteVinte}";
        }

        #endregion


    }
}
