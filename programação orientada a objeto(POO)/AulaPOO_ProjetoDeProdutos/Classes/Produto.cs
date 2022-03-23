using System;
using System.Collections.Generic;

namespace SistemasDeProdutos_2112.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Usuario Cadastradopor { get; set; }
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void CadastrarProduto(){
            Produto produto = new Produto();
            Marca Marca = new Marca();

            Console.WriteLine("Adicione um codigo para seu produto:");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Acrescente um nome para o seu produto");
            produto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Acrescente um valor ao seu produto");
            produto.Preco = float.Parse(Console.ReadLine());

            produto.DataCadastro = DateTime.UtcNow;

            produto.Marca = Marca.CadastrarMarca();

            produto.Cadastradopor = new Usuario();

            ListaDeProdutos.Add(produto);
       }
        public void ListarProdutos(){

            if (ListaDeProdutos != null)
            {
                foreach (var item in ListaDeProdutos)
                {
                Console.WriteLine("-----Lista de produtos-----");
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: R$ {item.Preco}");
                Console.WriteLine($"Marca: {item.Marca}");
                }
            }else
            {
                Console.WriteLine("Nenhum produto cadastrado ainda");
            }
        }
        public void DeletarProduto(int cod){

            Produto produto = ListaDeProdutos.Find(x => x.Codigo == cod);
            ListaDeProdutos.Remove(produto);
        }
        
        
        
        
        
        
        
        
        
    }
}