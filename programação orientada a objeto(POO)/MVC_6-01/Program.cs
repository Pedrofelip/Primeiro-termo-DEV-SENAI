using System;
using MVC_console.Controller;

namespace MVC_console
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController produtoController = new ProdutoController();
           produtoController.MostrarTodos();
        }
    }
}
