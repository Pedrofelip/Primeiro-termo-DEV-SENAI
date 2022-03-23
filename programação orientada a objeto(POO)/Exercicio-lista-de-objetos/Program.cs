using System;
using System.Collections.Generic;
using Listas_de_objetos.classes;

namespace Listas_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cartao> cartao = new List<Cartao>();

            cartao.Add(new Cartao("Pedro", 2222,"MasterCard", 2030, 393));
            cartao.Add(new Cartao("Mari", 3333,"MasterCard", 2030, 357));
            cartao.Add(new Cartao("Mafalda", 4444,"MasterCard", 2030, 458));
            cartao.Add(new Cartao("Gabriele", 5555,"MasterCard", 2030, 171));

            foreach (var item in cartao)
            {
                Console.WriteLine($"Nome titular: {item.Titular}\nNumero: {item.Numero}\nBandeira: {item.Bandeira}\nVencimento do catão: {item.Vencimento}\nCVV: {item.Cvv}\n-----------------------------");
            }
        }
    }
}
