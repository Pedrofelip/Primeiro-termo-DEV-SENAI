using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int [10];
            int maior;
            int menor;
            string resposta;
            
            Console.WriteLine("digite sim");
            resposta = Console.ReadLine();
            
            Console.WriteLine("Adicione um numero a baixo:");
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("adicione o "+(i+1)+"° numero:");
                numero[i] = int.Parse(Console.ReadLine());
            }

           if (resposta == "sim")
           {
               maior = numero[0];
               menor = numero[0];
               for (var i = 1; i < numero.Length; i++)
               {
                   if (maior<numero[i])
                   {
                       maior = numero[i];
                   }
                   else if (menor>numero[i])
                   {
                       menor = numero[i];
                   }
                   else{
                       Console.WriteLine("Obrigado pela visita :)");
                   }
               }
           Console.WriteLine($"O maior numero digitado foi: {maior}\nO menor numero digitado foi: {menor}");
           }


        }
    }
}
