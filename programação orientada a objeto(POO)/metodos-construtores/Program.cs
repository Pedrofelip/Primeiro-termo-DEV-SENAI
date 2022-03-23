using System;
using Metodos_construtores.classes;

namespace Metodos_construtores
{
    class Program
    {
        static void Main(string[] args)
        {
           Cadastro produto1 = new Cadastro();
           int produto2c;


        // comeco segundo metodo
           produto1.Codigo = 10;
           produto1.Nome = "Trakinas";
           produto1.Descricao = "Bolacha recheada";
           produto1.Estoque = 1000;

           Console.WriteLine($"Codigo: {produto1.Codigo}\nNome: {produto1.Nome}\nDescrição: {produto1.Descricao}\nEstoque: {produto1.Estoque}");


        // comeco segundo metodo
           Console.WriteLine("Por favor adicione o codigo do produto:");
           produto2c = int.Parse(Console.ReadLine());
           Cadastro produto2 = new Cadastro(produto2c);
           Console.WriteLine($"esse é o codigo do produto {produto2.Nome}");

        // comeco terceiro metodo

           Cadastro produto3 = new Cadastro(1000,"Biscoito toddy","Biscoito de chocolate",100);
           Console.WriteLine($"Codigo: {produto3.Codigo}\nNome: {produto3.Nome}\nDescrição: {produto3.Descricao}\nEstoque: {produto3.Estoque}");
        }
    }
}
