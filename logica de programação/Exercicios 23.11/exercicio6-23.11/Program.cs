using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [5];
            string busca;

            Console.WriteLine("Escreva os nomes a baixo:");
            for (var i = 0; i <5; i++)
            {
                Console.WriteLine($"{i+1}° nome:");
                nomes[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Digite o nome para busca no sistema:");
            busca = Console.ReadLine();
            for (var i = 0; i <1; i++)
            {
            if (busca == nomes[i])
            {
                Console.WriteLine("ACHEI!!!");
            }
            else
            {
                Console.WriteLine("Não achei :(");
            }
            }

        }
    }
}
