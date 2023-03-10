using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Entity_Framework_Players
{
    public class CalcioContext : DbContext
    {
        public DbSet<Player> players { get; set; }
        public DbSet<Team> teams { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=CalcioDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
