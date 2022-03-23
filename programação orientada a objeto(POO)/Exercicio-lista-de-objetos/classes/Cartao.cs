namespace Listas_de_objetos.classes
{
    public class Cartao
    {
        public string Titular { get; set; }
        public int Numero {get; set;}
        public string Bandeira {get; set;}
        public float Vencimento{get; set;}
        public int Cvv{get; set;}

        public Cartao(string titular, int numero, string bandeira, float vencimento, int cvv){

            this.Titular = titular;
            this.Numero = numero;
            this.Bandeira = bandeira;
            this.Vencimento = vencimento;
            this.Cvv = cvv;

        }

    }
}