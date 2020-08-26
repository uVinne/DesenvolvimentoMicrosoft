using System;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class CadastrarCliente
    {
        public static void Renderizar()
        {

            Cliente c = new Cliente();

            Console.WriteLine(" -------- Cadastro de Clientes --------\n");
            Console.WriteLine("Digite o nome do cliente");
            c.Nome = Console.ReadLine();

            Console.WriteLine("Digite o cpf do cliente");
            c.Cpf = Console.ReadLine();

            if (Validacao.ValidarCpf(c.Cpf))
            {
                if (ClienteDAO.Cadastrar(c))
                {
                    Console.WriteLine("Cliente cadastrado");
                }
                else
                {
                    Console.WriteLine("Cliente ja existe");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido");
            }
        }

    }
}
