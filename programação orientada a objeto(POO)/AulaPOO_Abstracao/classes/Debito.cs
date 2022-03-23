namespace POO_abstracao.classes
{
    public class Debito
    {
        private float saldo = 600;

        public void pagar(float valor){

        }

        public string Condicao(float valor){
            if (valor > saldo)
            {
                return "Saldo insuficiente para a compra";
            }
            else
            {
                return "Compra aprovada";
            }
        }

    }
}