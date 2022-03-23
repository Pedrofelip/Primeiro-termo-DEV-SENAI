using System;

namespace primeiro_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem1 = new Personagem();

            personagem1.nome = "Pedro";
            personagem1.idade = 18;
            personagem1.armadura = "A braba";

            Personagem personagem2 = new Personagem();

            personagem2.nome = "Felipe";
            personagem2.idade = 18;
            personagem2.armadura = "Quebra tudo";

            Console.WriteLine($"{personagem1.nome} - {personagem1.Atacar()}");
            Console.WriteLine($"{personagem2.nome} - {personagem2.Defender()}");
        }
    }
}
