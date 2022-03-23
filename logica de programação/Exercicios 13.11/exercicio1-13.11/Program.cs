using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adicione seu nome a baixo:");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine("Agora adicione sua idade a baixo e descubra seu tempo na terra:");
            int idadeCliente = int.Parse (Console.ReadLine());
            int meses = (idadeCliente*12);
            int dias = (idadeCliente*365);
            int horas = (idadeCliente*8760);
            int minutos = (idadeCliente*525600);
            Console.WriteLine(nomeCliente+" Você tem "+meses+ " meses, "+dias+" dias, "+horas+ " horas " +minutos+ " minutos na terra!!!");
        }
    }
}
