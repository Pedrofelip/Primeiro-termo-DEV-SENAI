using System;

namespace sistema_de_notas_aula_20._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomeAluno = new string [10];
            float[] nota1 = new float [10];
            float[] nota2 = new float [10];
            float[] nota3 = new float [10];
            float[] nota4 = new float [10];   
            float[] media = new float [10];       

            for (int name = 0; name < 10; name++)
            {
            Console.WriteLine($"Escreva o nome do {name+1}° aluno:");
            nomeAluno[name] = Console.ReadLine();
            Console.WriteLine($"adicione a primeira nota de {nomeAluno[name]}:");
            nota1[name] = float.Parse(Console.ReadLine());
            Console.WriteLine($"adicione a segunda nota de {nomeAluno[name]}:");
            nota2[name] = float.Parse(Console.ReadLine());
            Console.WriteLine($"adicione a terceira nota de {nomeAluno[name]}:");
            nota3[name] = float.Parse(Console.ReadLine());
            Console.WriteLine($"adicione a quarta nota de {nomeAluno[name]}:");
            nota4[name] = float.Parse(Console.ReadLine());

            media[name] = (nota1[name]+nota2[name]+nota3[name]+nota4[name])/4;

            if (media[name] >= 7)
            {
                Console.WriteLine($"A media do(a) aluno(a) {nomeAluno[name]} é de {media[name]}. O aluno foi APROVADO:)");
            }
            else
            {
                Console.WriteLine($"A media do(a) aluno(a) {nomeAluno[name]} é de {media[name]}. O aluno foi REPROVADO:(");
            }

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("esse foi o final da aplicação");
            }



            
        }
    }
}
