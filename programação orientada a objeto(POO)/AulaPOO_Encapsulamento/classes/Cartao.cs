namespace POO_encapsulamento.classes
{
    public class Cartao
    {
        private string numero;

        private string bandeira;

        protected string token = "qwertyui";

        private string cvv;

        protected float limite = 5000;


        public string RegistrarCompra(bool validado){
            return "";
        }
    
        private bool ValidarCompra(float saldo){
            return true;
        }

        protected string ValidarToken(string senha){
            return "";
        }
    }
}