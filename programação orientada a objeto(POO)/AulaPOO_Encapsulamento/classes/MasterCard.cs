namespace POO_encapsulamento.classes
{
    public class MasterCard : Cartao
    {
        private int parcelas;

        public int Parcelas{
                set{parcelas = value;}
                get{return parcelas;}
        }

        public string ComprarComDesconto(){
            return"";
        }
    }
}