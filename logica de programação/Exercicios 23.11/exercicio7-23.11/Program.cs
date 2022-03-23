using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [15];

            Console.WriteLine("Adicione os numeros a baixo:");
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{i+1}° numero:");
                numeros[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Valores inseridos na ordem inversa:");
            for (var i = 0; i < numeros.Length; i++)
            {
                Array.Reverse(numeros);
                Console.WriteLine($"{numeros[i]}");
            }
        }
    }
}
