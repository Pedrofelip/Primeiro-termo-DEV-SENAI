using System;

namespace logica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Soma de dois numeros");
            Console.WriteLine("-----------------------------------");
            Console.Write("digite o primeiro valor:");
            int valorUm = int.Parse (Console.ReadLine());
            Console.Write("digite o segundo valor:");
            int valorDois = int.Parse (Console.ReadLine());
            int soma = valorUm + valorDois;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine ("A soma do"+valorUm+" + "+valorDois+" = "+soma);

        }
    }
}
