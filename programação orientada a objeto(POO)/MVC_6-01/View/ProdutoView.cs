using System;
using System.Collections.Generic;
using MVC_console.Model;

namespace MVC_console.View
{
    public class ProdutoView
    {
        public void ListarTodos(List<Produto> produto){

            foreach (var item in produto)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
            }
        }
    }
}