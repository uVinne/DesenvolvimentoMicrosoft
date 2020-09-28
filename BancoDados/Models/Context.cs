using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDados.Models
{
    class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }



        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\MSSQLLocalDB;Database=PessoasDb;Trusted_Connection=True");
        }

    }
}
