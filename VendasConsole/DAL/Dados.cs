using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class Dados
    {
        public static void Inicializar()
        {
            Cliente cliente = new Cliente
            {
                Nome = "Vinicius",
                Cpf = "12547575973"
            };
            ClienteDAO.Cadastrar(cliente);
            Vendedor vendedor = new Vendedor
            {
                Nome = "Joao",
                Cpf = "12547575973"
            };
            VendedorDAO.Cadastrar(vendedor);
            Produto produto = new Produto
            {
                Nome = "pao",
                Preco = 1.10,
                Quantidade = 20
            };
            ProdutoDAO.Cadastrar(produto);

        }
    }
}
