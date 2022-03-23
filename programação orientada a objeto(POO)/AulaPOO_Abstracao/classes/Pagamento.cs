using System;

namespace POO_abstracao.classes
{
    public abstract class Pagamento
    {
        private DateTime data;

        protected float valor;


        public string Cancelar(){
            return "";
        }

        
    }
}