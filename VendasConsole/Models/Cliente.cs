using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models
{
    class Cliente
    {

        public Cliente()
        {
            Criadoem = DateTime.Now;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public DateTime Criadoem { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em :{Criadoem}";
        }

    }
}
