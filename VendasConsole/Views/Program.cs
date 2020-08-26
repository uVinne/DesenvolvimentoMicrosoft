using System;

namespace VendasConsole.Views
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
                /*Console.WriteLine("3 - Cadastrar Vendedor");
                Console.WriteLine("4 - Listar vendedores");
                Console.WriteLine("5 - Cadastrar Produto");
                Console.WriteLine("6 - Listar Produtos");*/
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente.Renderizar();
                        break;

                    case 2:
                        ListarClientes.Renderizar();
                        break;
                    case 3:
                        string idade = 25 > 18 ? "Maior" : "Menor";

                        break;

                    /*case 3:
                        v = new Vendedor();

                        Console.WriteLine("-------- Cadastro de Vendedores --------\n");
                        Console.WriteLine("Digite o nome do vendedor");
                        v.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o Cpf do vendedor");
                        v.Cpf = Console.ReadLine();

                        vendedores.Add(v);

                        Console.WriteLine("Vendedor cadastrado!");
                        break;

                    case 4:
                        Console.WriteLine(" -------- Lista de Vendedores --------\n");
                        foreach (Vendedor vendedorCadastrado in vendedores)
                        {
                            Console.WriteLine(vendedorCadastrado);
                        }

                        break;*/

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
