using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace VendasWPF.Models
{
    class Context : DbContext
    {
        public DbSet <Cliente> Clientes { get; set; }

        public DbSet <Vendedor> Vendedores { get; set; }

        public DbSet <Produto> Produtos { get; set; }

        public DbSet <Venda> Vendas { get; set; }

        public DbSet <ItemVenda> ItensVenda { get; set; }

        protected override void OnConfiguring
           (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\MSSQLLocalDB;Database=VendasWPF;Trusted_Connection=True");
        }
    }
}
