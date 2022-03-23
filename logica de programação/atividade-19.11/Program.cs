using System;

namespace aula_dia_19._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [5];
            int[] idade = new int [5];

            for (var contador = 0; contador < 5; contador++)
            {
                Console.WriteLine($"digite o {contador+1}° nome:");
                nomes [contador] = Console.ReadLine();
                Console.WriteLine("digite a idade de "+nomes[contador]+":");
                idade [contador] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("nomes cadastrados:");
            for (var contador = 0; contador < 5; contador++)
            {
                Console.WriteLine($"nome: {nomes [contador]}");
                Console.WriteLine($"idade:{idade[contador]}");
            }
        }
    }
}
