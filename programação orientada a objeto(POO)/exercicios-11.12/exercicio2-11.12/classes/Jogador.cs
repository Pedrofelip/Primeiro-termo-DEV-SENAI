using System;

namespace exercicio2_1112.classes
{
    public class Jogador
    {
        public string nome;
        public int posicao;
        public int dataDeNascimento;
        public string nacionalidade;
        public float altura;
        public float peso;

        public void Dados(){

            Console.WriteLine("-------Ficha do jogador-------");
            Console.WriteLine($"Nome: {nome}\nData de nascimento: {dataDeNascimento}\nNacionalidade: {nacionalidade}\nAltura: {altura}\nPeso: {peso}\nPosição em campo: {posicao}");
        }

        public void Idade(int dataDeNascimento){
            int idade = 2021 - dataDeNascimento;
            Console.WriteLine($"A idade do jogador {nome} é de {idade}");

            ;
        }

        public void Aposenta(int posicao){

            int idade = 2021 - dataDeNascimento;

           switch (posicao)
           {
               case 1:
                        if (idade <= 40)
                        {
                            int tempo = 40 - idade;
                            Console.WriteLine($"Faltam {tempo} anos para o jogador {nome} se aposentar");
                        }else
                        {
                            Console.WriteLine("A idade do jogador não está valida para a posição");
                        }
                   break;
                case 2:
                        if (idade <= 38)
                        {
                            int tempo = 38 - idade;
                            Console.WriteLine($"Faltam {tempo} anos para o jogador {nome} se aposentar");
                        }else
                        {
                            Console.WriteLine("A idade do jogador não está valida para a posição");
                        }
                    break;
                case 3:
                        if (idade <= 35)
                        {
                            int tempo = 35 - idade;
                            Console.WriteLine($"Faltam {tempo} anos para o jogador {nome} se aposentar");
                        }else
                        {
                            Console.WriteLine("A idade do jogador não está valida para a posição");
                        }
                    break;
               default:
                   break;
           }
           
        }
    }
}