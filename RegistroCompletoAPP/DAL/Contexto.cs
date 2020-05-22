using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroCompletoAPP.Models;

namespace RegistroCompletoAPP.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Personas.db");
        }
    }
}
