using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adicione seu nome a baixo:");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine("Adicione seu ano de nascimento:");
            float dataCliente = float.Parse(Console.ReadLine());
            float resultado = (2021-dataCliente);
            float semanas = (resultado * 52);
            Console.WriteLine(nomeCliente+" se você já fez aniversario em 2021 sua idade é "+resultado+" se ainda não fez subtraia -1 no resultado final. E você tem um total de "+semanas+" semanas na terra!!!!");

        }
    }
}
