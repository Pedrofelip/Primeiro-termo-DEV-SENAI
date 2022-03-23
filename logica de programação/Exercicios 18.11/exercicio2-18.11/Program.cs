using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)

        
        {
            string nomeUser;
            string senhaUser;

            Console.WriteLine("Adicione seu nome de usuario a baixo:");
            nomeUser = Console.ReadLine();
            Console.WriteLine("Adicione uma senha para seu perfil (somente letras):");
            senhaUser = Console.ReadLine();

            while (nomeUser==senhaUser)
            {
                Console.WriteLine("nome de usuario e senha não podem ser iguais, por favor tente novamente:");
                Console.WriteLine("Adicione seu nome de usuario a baixo:");
                nomeUser = Console.ReadLine();
                Console.WriteLine("Adicione uma senha para seu perfil somente com letras:");
                senhaUser = Console.ReadLine();
            }
            Console.WriteLine("nome de usuario e senha validos, seu cadastro foi concluido :)");

        }
    }
}
