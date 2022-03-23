using System.Collections.Generic;
using System.IO;

namespace MVC_console.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public Produto(){

            string pasta = PATH.Split("/")[0];

            if(!Directory.Exists(pasta)){

                Directory.CreateDirectory(pasta);

            }
            if(!File.Exists(PATH)){

                File.Create(PATH);

            }
        }

        public List<Produto> Ler(){
            
            List<Produto> produto = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto prod = new Produto();

                prod.Codigo = int.Parse(atributos[0]);
                prod.Nome = atributos[1];
                prod.Preco = float.Parse(atributos[2]);

                produto.Add(prod);
            }

            return produto;
        }
        
        
        
        
        
        
    }
}