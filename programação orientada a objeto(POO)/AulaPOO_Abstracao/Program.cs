using System;
using POO_abstracao.classes;

namespace POO_abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            Debito debito = new Debito();
            Credito credito = new Credito();
            float valor;

            Console.WriteLine("Adicione o valor do produto adquirido:");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Escolha sua forma de pagamento");
            Console.WriteLine("[1] - Boleto");
            Console.WriteLine("[2] - Debito");
            Console.WriteLine("[3] - Credito");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine(boleto.Condicao(valor));
                    break;
                case "2":
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine(debito.Condicao(valor));
                    break;
                case "3":
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Em quantas vezes gostaria de parcelar?");
                            int parcelas = int.Parse(Console.ReadLine());
                            Console.WriteLine(credito.Condicao(valor, parcelas));
                    break;
                default:
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("opção invalida");
                    break;
            }
            

        }
    }
}
