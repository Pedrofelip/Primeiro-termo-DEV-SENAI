using System;

namespace SistemasDeProdutos_2112.Classes
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario(){
            CadastrarUsuario();
        }
        public Usuario(string _nomeUsuario, string _email, string _senha){

            NomeUsuario = _nomeUsuario;
            Email       = _email;
            Senha       = _senha;

        }
        public void CadastrarUsuario(){

            NomeUsuario = "Pedro Felipe";
            Email = "Pedro@gmail.com";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow;

        }

        public void DeletarUsuario(){

            NomeUsuario = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("");

        }
        
        
        
        
        
        
        
        
        
        
    }
}