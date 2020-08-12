using System;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(" -------- Vendas --------\n");
                Console.WriteLine("1 - Cadastrar Clientes");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Cliente c = new Cliente();
                        Console.WriteLine(" -------- Cadastro de Clientes --------\n");
                        Console.WriteLine("Digite o nome do cliente");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o cpf do cliente");
                        c.Cpf = Console.ReadLine();

                        Console.WriteLine($"Cliente: {c.Nome}, Cpf:{c.Cpf}");
                        break;
                    case 2:
                        Console.WriteLine(" -------- Lista de Clientes --------\n");
                        break;
                    case 0:
                        Console.WriteLine("Saindo...\n");
                        break;
                    default:
                        Console.WriteLine("-------- CÓDIGO INVÁLIDO--------\n");
                        break;
                }

                Console.WriteLine("\nPressione uma tecla para continuar...");
                Console.ReadKey();

            } while (opcao != 0);
        }
    }
}
