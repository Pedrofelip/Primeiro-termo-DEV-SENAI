using System;

namespace estruturas_condicionais_12_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adicione o nome do aluno:");
            string nomeAluno = Console.ReadLine();
            Console.WriteLine("---------------------------------");
            Console.Write("adicione a primeira nota:");
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("adicione a segunda nota:");
            float nota2 = float.Parse(Console.ReadLine());
            Console.Write("adicione a terceira nota:");
            float nota3 = float.Parse(Console.ReadLine());
            float media = (nota1+nota2+nota3)/3;
            Console.WriteLine("---------------------------------");
            if (media>5) {Console.WriteLine("O aluno "+nomeAluno+" foi aprovado com a media de "+media);}
            else{Console.WriteLine("O aluno "+nomeAluno+" foi reprovado com a media de "+media);}

        }
    }
}
