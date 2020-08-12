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
                        Console.WriteLine(" -------- Cadastro de Clientes --------\n");
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
