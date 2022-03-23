using System;
using POO_inerfaces.classes;

namespace POO_inerfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto(1, "Bolacha trakinas", 2);
            Produto p2 = new Produto(2, "Biscoito toddy", 4);
            Produto p3 = new Produto(3, "Recheadinho balducco", 3);
            Produto p4 = new Produto(4, "Bolinho ana maria", 1.50f);

            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);

            carrinho.Alterar(3, p4);


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            carrinho.Listar();
            Console.ResetColor();
        }
    }
}
