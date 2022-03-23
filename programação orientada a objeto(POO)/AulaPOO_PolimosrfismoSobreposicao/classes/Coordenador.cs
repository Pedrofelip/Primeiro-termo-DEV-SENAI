using System;

namespace POO_polimorfismo.classes
{
    public class Coordenador : Taxa
    {
        public string tipo;

        public override void valeRefeicao()
        {
            Console.WriteLine("Ataxa para coordenador é de 20%");
        }
    }
}