namespace POO_abstracao.classes
{
    public class Credito
    {
        float valor2;

        private float limite = 3000;

        public void pagar(float valor){
            
        }

        public string Condicao(float valor, int parcelas){

            
                if ( parcelas <= 6)
                {
                    float valor1 = valor*0.05f;
                    valor2 = valor + valor1;
                    
                    return $"Sua compra ficou em {parcelas} vezes de {valor2/parcelas} com  valor total de {valor2}";

                }else if (parcelas >=7 || parcelas <= 12)
                {
                    float valor1 = valor*0.08f;
                    valor2 = valor + valor1;
                    
                    return $"Sua compra ficou em {parcelas} vezes de {valor2/parcelas} com  valor total de {valor2}";
                }
                else
                {
                }

                return $"Sua compra ficou em {parcelas} vezes de {valor2/parcelas}";
        }
    }
}