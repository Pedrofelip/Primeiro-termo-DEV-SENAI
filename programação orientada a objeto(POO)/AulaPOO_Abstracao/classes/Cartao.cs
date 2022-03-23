namespace POO_abstracao.classes
{
    public class Cartao : Pagamento
    {
        protected string bandeira;

        protected string numero;

        public string titular;

        protected int cvv;

        public string SalvarCartao(){
            return"";
        }

        
    }
}