using System;
using System.Collections.Generic;

namespace SistemasDeProdutos_2112.Classes
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Marca> Marcas = new List<Marca>();
        
        public Marca CadastrarMarca(){

            Marca novaMarca = new Marca();

            Console.WriteLine("Adicione o codigo da sua marca:");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Acrescente um nome para sua marca:");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
            
        }

        public void Listar(){

        if (Marcas != null)
        {
            Console.WriteLine("-----Marcas cadastradas-----");
            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Codigo da marca: {item.Codigo}");
                Console.WriteLine($"Nome da marca: {item.NomeMarca}");
                Console.WriteLine($"Data de cadastro: {item.DataCadastro}");
            }
        }else
        {
            Console.WriteLine("Nenhuma marca cadastrada ainda");
        }
        }

        public void DeletarMarca(int cod){
            
            Marca marcaDelete = Marcas.Find(x => x.Codigo == cod);
            Marcas.Remove(marcaDelete);


        }
        
        
        
        
        
        
        
    }
}