using System;
using celular02.classes;

namespace celular02
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular cell = new Celular();

            Console.WriteLine("Ligar celular? s/n");
            string resposta = Console.ReadLine();

            if (resposta == "s")
            {
                cell.modo = true;
            }
            else
            {
                cell.modo = false;
            }

            if (cell.modo == true)
            {
                int resposta2;
                string resposta3;
                do
                {
                    Console.WriteLine("---------menu---------");
                    Console.WriteLine("[1] - Fazer ligação");
                    Console.WriteLine("[2] - Enviar mensagem");
                    Console.WriteLine("[0] - Desligar");
                    resposta2 = int.Parse(Console.ReadLine());

                    switch (resposta2)
                    {
                        case 1:
                        Console.WriteLine("digite o numero:");
                        int telefone = int.Parse(Console.ReadLine());
                        Console.WriteLine($"ligando para {telefone} ......");
                        Console.WriteLine("Infelizmente foi impossivel completar a chamada, por favor tente mais tarde :)");

                            break;
                        case 2:
                        Console.WriteLine("Digite o nome (ou numero) do contato:");
                        string nome = Console.ReadLine();
                        do
                        {
                        Console.WriteLine("Digite a mensagem:");
                        string mensagem = Console.ReadLine();
                        Console.WriteLine("mensagem envida com sucesso");
                        Console.WriteLine($"Deseja enviar outra mensagem para {nome}? s/n:");
                        resposta3 = Console.ReadLine();
                        } while (resposta3 == "s");
                            break;
                        case 0:
                            Console.WriteLine("Desligando celular");
                            break;
                        default:
                            Console.WriteLine("Opção invalida, Tente novamente");
                            break;
                    }
                    
                } while (resposta2 != 0);
            }
            else
            {
                Console.WriteLine("Celular Desligado");
            }
        }
    }
}
