using BancoDados.DAL;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDados.Views
{
    class RemoverPessoa
    {
        public static void Renderizar()
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine(" --- REMOVER PESSOA --- \n");
            Console.WriteLine("Digite o email da pessoa: ");
            pessoa.Email = Console.ReadLine();
            pessoa = PessoaDAO.BuscarPorEmail(pessoa.Email);
            if (pessoa != null)
            {
                PessoaDAO.Remover(pessoa);
                Console.WriteLine("Pessoa removida!");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada");
            }

        }
    }
}
