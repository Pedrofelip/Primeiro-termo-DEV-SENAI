using System;

namespace POO_polimorfismo.classes
{
    public abstract class Taxa
    {
        public float valor;

        public virtual void valeRefeicao(){

            Console.WriteLine("A taxa é de 5%");

        }
    }
}