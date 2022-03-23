using System;
using System.Collections.Generic;

namespace Objetos_como_argumento.classes
{
    public class Carrinho
    {
        public float ValorCarrinho { get; set; }

       
        List<Produto> carrinho = new List<Produto>();

        public void AdicionarCarrinho(Produto produto){

            carrinho.Add(produto);

        }

        public void RemoverCarrinho(Produto produto){

            carrinho.Remove(produto);

        }

        public void ListarProdutos(){

            if (carrinho != null)
            {
                foreach (Produto item in carrinho)
                {

                    Console.WriteLine($"Codigo: {item.Codigo}\nProduto: {item.Nome}\nPreço: {item.Preco}\n--------------------------");

                }
                    MostrarTotal();
            }
        }

        public void MostrarTotal(){

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            if (carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    ValorCarrinho += item.Preco;
                }
                Console.WriteLine($"O valor total: R$ {ValorCarrinho.ToString("n2")}");
            }else
            {
                Console.WriteLine("Nenhum produto adicionado ao carrinho");
            }
            Console.ResetColor();
        }
        
        public void AlterarItem(int codigo, Produto produtoNovo){
            carrinho.Find(x => x.Codigo == codigo).Nome = produtoNovo.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = produtoNovo.Preco;
            carrinho.Find(x => x.Codigo == codigo).Codigo = produtoNovo.Codigo;
        }
    }
}