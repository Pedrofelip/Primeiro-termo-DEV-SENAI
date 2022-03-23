using System;

namespace SistemasDeProdutos_2112.Classes
{
    public class Login
    {
         string emailLogin;
         string senhaLogin;
         
        public bool Logado { get; set; }

        public Login(){
            Usuario user = new Usuario();

            Logar(user);

            if (Logado)
            {
                GerarMenu();
            }
        }
        public void GerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();


            string opcao = "n";

                Console.WriteLine("Bem vindo a nossa plataforma");
                do
                {
                Console.WriteLine("-----------Menu-----------");
                Console.WriteLine("[1] - Cadastrar produto ");
                Console.WriteLine("[2] - Listar produtos");
                Console.WriteLine("[3] - Deletar produtos");
                Console.WriteLine("[4] - Adicionar marca ");
                Console.WriteLine("[5] - Listar marcas");
                Console.WriteLine("[6] - Deletar marca");
                Console.WriteLine("[0] - Sair ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": 
                        produto.CadastrarProduto();
                        break;

                    case "2":
                        produto.ListarProdutos();
                        break;

                    case "3":
                        Console.WriteLine("Escreva o codigo do produto qu deseja exluir:");
                        int produtoDelete = int.Parse(Console.ReadLine());
                        produto.DeletarProduto(produtoDelete);
                        break;

                    case "4":
                        marca.CadastrarMarca();
                        break;

                    case "5":
                        marca.Listar();
                        break;

                    case "6":
                        Console.WriteLine("Escreva o codigo do produto qu deseja exluir:");
                        int marcaDelete = int.Parse(Console.ReadLine());
                        marca.DeletarMarca(marcaDelete);
                        break;

                    default:
                        break;
                }
                
                    
                } while (opcao != "0");
        }
        public void Logar(Usuario usuario){
            do
            {
                Console.WriteLine("Digite seu email:");
                emailLogin = Console.ReadLine();

                Console.WriteLine("Digite sua senha:");
                senhaLogin = Console.ReadLine();

                if (emailLogin == usuario.Email && senhaLogin == usuario.Senha)
                {
                    Logado = true;
                }else
                {
                    Console.WriteLine("Email ou senha incorretos por favor tente novamente");
                }
                
            } while (emailLogin != usuario.Email || senhaLogin != usuario.Senha);

        }

        public void Deslogar(){

            Logado = false;

        }
    }
}