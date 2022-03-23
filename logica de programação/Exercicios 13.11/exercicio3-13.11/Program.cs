using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adicione o nome do funcionario a baixo:");
            string nomeFuncionario = (Console.ReadLine());
            Console.WriteLine("Adicione o valor referente ao salario do funcionario:");
            float salario1 = float.Parse (Console.ReadLine());
            float salario2 = (salario1 / 10);
            float salario3 = (salario2*3);
            float salario4 = (salario3 + salario1);
            if (salario1 < 500){Console.WriteLine(nomeFuncionario+" você tem direito ao reajuste de 30% em seu salario, seu novo salario é "+salario4+" reais!!");}
            else
            {
                Console.WriteLine("Infelizmente você não tem direito ao reajuste salarial da empresa :(");
            }


        }
    }
}
