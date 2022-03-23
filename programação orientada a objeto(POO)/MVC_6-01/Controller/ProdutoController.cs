using System.Collections.Generic;
using MVC_console.Model;
using MVC_console.View;

namespace MVC_console.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView view = new ProdutoView();


    public void MostrarTodos(){

        List<Produto> todos = produto.Ler();

        view.ListarTodos(todos);
    }
    }

}
