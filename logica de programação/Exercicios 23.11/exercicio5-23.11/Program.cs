using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inicio;
            int resultado;

            Console.WriteLine("Gostaria de saber a tabuada do 1 ao 10? digite sim ou não");
            inicio = Console.ReadLine();
            
            if (inicio == "sim")
            {
                for (var i = 0; i <= 10; i++)
                {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("tabuada do "+(i));
                    for (var n = 0; n <= 10; n++)
                    {
                        resultado = i*n;
                        Console.WriteLine($"{n} x {i} = {resultado} ");
                       
                    }
                }
            }
            else
            {
                Console.WriteLine("Obrigado pela visita :)");
            }
        }
    }
}
