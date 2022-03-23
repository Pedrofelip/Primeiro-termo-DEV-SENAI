using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta1;
            string nomeUser;
            int idadeUser;
            int salario;
            string resposta2;

            Console.WriteLine("gostaria de se cadastrar em nosso site? digite sim ou não");
            resposta1 = Console.ReadLine();
            if (resposta1=="sim")
            {
                
            Console.WriteLine("escreva seu nome de usuario a baixo:");
            nomeUser = Console.ReadLine();
            
            while (nomeUser == "")
            {
                Console.WriteLine("o campo nome de usuario está vazio, por favor tente novamente");
                Console.WriteLine("escreva seu nome de usuario a baixo:");
                nomeUser = Console.ReadLine();
            }

            Console.WriteLine("Adicione sua idade:");
            idadeUser = int.Parse(Console.ReadLine());
            while (idadeUser<0 || idadeUser>150)
            {
                Console.WriteLine("idade invalida, por favor tente novamente");
                Console.WriteLine("Adicione sua idade:");
                idadeUser = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Adicione seu salario a baixo:");
            salario = int.Parse(Console.ReadLine());
            while (salario<0)
            {
                Console.WriteLine("valor salarial invalido, por favor tente novamente");
                Console.WriteLine("Adicione seu salario a baixo:");
                salario = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Adicione seu estado civil:");
            Console.WriteLine("s - solteiro(a)");
            Console.WriteLine("c - casado(a):");
            Console.WriteLine("v - viuvo(a):");
            Console.WriteLine("d - divorciado(a)");
            resposta2 = Console.ReadLine();

            

            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("seu cadastro foi concluido com sucesso, segue as informações processadas pelo sistema ;)");
            Console.WriteLine($"nome do usuario: {nomeUser}\nidade: {idadeUser}\nsalario: {salario}\nestado civil: {resposta2}");


            }

            else
            {
                Console.WriteLine("Ué então pra que veio?");
            }
        }
    }
}
