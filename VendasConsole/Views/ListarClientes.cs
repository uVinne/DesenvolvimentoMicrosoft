using System;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine(" -------- Lista de Clientes --------\n");
            foreach (Cliente clienteCadastrado in ClienteDAO.Listar())
            {
                Console.WriteLine(clienteCadastrado);
            }

        }

    }
}
