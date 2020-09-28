using BancoDados.DAL;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoDados.Views
{
    class CadastrarPessoa
    {
        public static void Renderizar()
        {
            PessoaDAO.Cadastrar(
               new Pessoa
               {
                   Nome = "Maria Faria",
                   Email = "maria@maria.com"
               }
           );

            Console.WriteLine("Pessoa cadastrada com sucesso!!!");

            foreach (Pessoa pessoaCadastrada in PessoaDAO.Listar())
            {
                Console.WriteLine(pessoaCadastrada);
            }
        }
    }
}

