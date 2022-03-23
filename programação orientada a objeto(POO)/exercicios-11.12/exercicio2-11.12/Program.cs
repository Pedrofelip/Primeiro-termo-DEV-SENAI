using System;
using exercicio2_1112.classes;

namespace exercicio2_1112
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Jogador jogador = new Jogador();
            Console.WriteLine("Adicione o nome do jogador a baixo:");
            jogador.nome = Console.ReadLine();

            Console.WriteLine("Indique a posição em campo do jogador:");
            Console.WriteLine("Escolha a posição do jogador");
            Console.WriteLine("[1] - Defesa");
            Console.WriteLine("[2] - Meio-campo");
            Console.WriteLine("[3] - Atacante");
            jogador.posicao = int.Parse(Console.ReadLine());

            Console.WriteLine("Adicione o ano de nascimento do jogador:");
            jogador.dataDeNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Adicione a nacionalidade do jogador:");
            jogador.nacionalidade = Console.ReadLine();

            Console.WriteLine("Adicione a altura do jogador:");
            jogador.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Adicione o peso do jogador:");
            jogador.peso = float.Parse(Console.ReadLine());

            do
            {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Escolha uma das opções a baixo:");
            Console.WriteLine("[1] - Ver ficha do jogador");
            Console.WriteLine("[2] - Ver a idade do jogador");
            Console.WriteLine("[3] - Ver se o jogador está apto para sua posição");
            Console.WriteLine("[0] - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                        jogador.Dados();
                    break;
                case 2:
                        jogador.Idade(jogador.dataDeNascimento);
                    break;
                case 3:
                        jogador.Aposenta(jogador.posicao);
                    break;
                default:
                        Console.WriteLine("opção invalida, tente novamente");
                    break;
            }
                
            } while (opcao != 0);
            
            
        }
    }
}
