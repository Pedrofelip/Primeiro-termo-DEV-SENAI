using System;

namespace sistema_de_passagens_areas_25._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;
            int escolha; 
            string[] nomePass = new string[5];
            string[] destino = new string[5];
            string[] pontoi = new string[5];
            string[] dataV = new string[5];
            int i = 0;
            string resposta;
            


            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("---Seja bem-vindo ao compra de passagens---");
            Console.WriteLine("-------------------------------------------");
            do
            {
            Console.WriteLine("\nAdicione sua senha para logar em sua conta:");
            senha = Console.ReadLine();
            } while (senha != "123456");
            Console.Clear();
            do
            {
                Console.WriteLine("menu inicial");
                Console.WriteLine("selecione uma opcão:");
                Console.WriteLine("[1] - cadastrar passagem");
                Console.WriteLine("[2] - listar as passagens");
                Console.WriteLine("[0] - sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        do
                        {
                            if (i<5)
                            {
                                Console.WriteLine("---Cadastrar passagem---");
                                Console.WriteLine($"adicione o nome do {i+1}° passageiro:");
                                nomePass[i] = Console.ReadLine();
                                Console.WriteLine($"localização do ponto de partida do {i+1}° passageiro:");
                                pontoi[i] = Console.ReadLine();     
                                Console.WriteLine($"localização do destino final do {i+1}° passageiro:");
                                destino[i] = Console.ReadLine();
                                Console.WriteLine($"adicione a data do voo do {i+1}° passageiro:");
                                dataV[i] = Console.ReadLine();

                                i++;
                                
                            }else
                            {
                                Console.WriteLine("O limete de cadastrados foi excedido");
                            }
                            
                                Console.WriteLine("Gosta de cadastrar um novo passageiro? responda sim ou não");
                                resposta = Console.ReadLine();
                        } while (resposta == "sim");
                        
                     break;

                    case 2:
                    Console.WriteLine("---lista de cadastros---");
                        for (var n = 0; n < 5; n++)
                    {
                            Console.WriteLine($"-----------cadastro do {n+1}° passageiro-----------");
                            Console.WriteLine($"Nome do {n+1}° passageiro: {nomePass[n]}");
                            Console.WriteLine($"Ponto de partido do {n+1}° passageiro: {pontoi[n]}");
                            Console.WriteLine($"Destino do {n+1}° passageiro: {destino[n]}");
                            Console.WriteLine($"Data do voo do {n+1}° passageiro: {dataV[n]}");
                            
                        
                    }

                        break;
                    default:
                        Console.WriteLine("Opção invalida, por favor tente novamente");
                        break;
                }
                
                
            } while (escolha!=0);
        }
    }
}
