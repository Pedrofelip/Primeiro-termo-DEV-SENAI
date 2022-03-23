using System;

namespace POO_estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.DolarParaReal(10));
            Console.WriteLine(Conversor.RealParaDolar(10));
            Console.WriteLine(Conversor.EuroParaReal(10));
            Console.WriteLine(Conversor.RealParaEuro(10));
            
            
        }
    }
}
