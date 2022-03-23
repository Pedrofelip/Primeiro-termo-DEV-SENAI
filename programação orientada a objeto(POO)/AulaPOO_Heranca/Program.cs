using System;
using POO_herenca.classes;

namespace POO_herenca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoa = new PessoaFisica();
            Console.WriteLine("Por favor adicione seu nome:");
            pessoa.nome = Console.ReadLine();
            Console.WriteLine(pessoa.DarBoasVindas(pessoa.nome));

            Console.WriteLine("adicione seu Rg:");
            pessoa.rg = Console.ReadLine();
            Console.WriteLine("adicione seu CPF:");
            pessoa.cpf = Console.ReadLine();
            // Console.WriteLine(pessoa.ValidarCPF(pessoa.cpf));

            if (pessoa.ValidarCPF(pessoa.cpf))
            {
                Console.WriteLine("CPF valido :)");
            }else
            {
                 Console.WriteLine("CPF invalido :)");
            }


        }
    }
}
