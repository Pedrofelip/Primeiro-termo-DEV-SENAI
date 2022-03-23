using System;
using Objetos_como_argumento.classes;

namespace Objetos_como_argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Bolacha Trakinas", 2f);
            Produto p2 = new Produto(2, "Suco de Laranja", 3f);
            Produto p3 = new Produto(3, "Misto quente", 5f);
            Produto p4 = new Produto(4, "Pepsi", 3f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarCarrinho(p1);
            carrinho.AdicionarCarrinho(p2);
            carrinho.AdicionarCarrinho(p3);
            carrinho.AdicionarCarrinho(p4);

            carrinho.ListarProdutos();
        }
    }
}
