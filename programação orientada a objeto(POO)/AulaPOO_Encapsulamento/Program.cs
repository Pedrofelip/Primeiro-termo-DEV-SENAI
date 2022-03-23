using System;
using POO_encapsulamento.classes;

namespace POO_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard novoCartao = new MasterCard();

            Console.WriteLine("Deseja parcelar em quantas vezes?");
            novoCartao.Parcelas = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você optou por parcelar em {novoCartao.Parcelas} vezes");

        }
    }
}
