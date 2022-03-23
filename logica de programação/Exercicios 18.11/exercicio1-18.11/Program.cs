using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;

            Console.WriteLine("adicione a nota a baixo:");
            nota = int.Parse(Console.ReadLine());

                while (nota<0 || nota>10)
                {
                    Console.WriteLine("nota invalida, por favor tente novamente");
                    Console.WriteLine("adicione a nota a baixo:");
                    nota = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("nota arquivada!");
        }
    }
}
