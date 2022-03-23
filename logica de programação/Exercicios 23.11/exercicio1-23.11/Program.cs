using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeCliente;
            int idade;

            Console.WriteLine("Verifique se você já tem idade para votar, adicione seu ano de nascimento a baixo:");
            idadeCliente = int.Parse(Console.ReadLine());
            idade = 2020 - idadeCliente;

            if (idade >= 18)
            {
                Console.WriteLine($"Sua idade já corresponde ao voto obrigatorio, compareça a sua zona eleitoral");
            }
            else if(idade >=16 && idade<=17){
                Console.WriteLine("Sua idade já permite que você vote mas o criterio fica a sua escolha");
            }
            else
            {
                Console.WriteLine("Sua idade ainda não permite que você vote");
            }
        }
    }
}
