using System;

namespace funcao_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adicione um numero cujo você queira saber a tabuada:");
            int numeroCliente = int.Parse(Console.ReadLine());

            for (var numero = 0; numero <= 10 ; numero++)
            {
                Console.WriteLine($"{numeroCliente} x {numero} = {numeroCliente*numero}");
            }
            Console.WriteLine("Essa foi a tabuada do " +numeroCliente+ "!!!"); 
            
        }
    }
}
