namespace POO_abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public void Registrar(){

        }

        public string Condicao(float valor)
        {
            float valor1 = valor*0.12f;
            float valor2 = valor - valor1;

            return $"O valor da sua compra ficou em {valor2}";
        }
    }
}