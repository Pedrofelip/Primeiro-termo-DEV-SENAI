using System;

namespace POO_polimorfismo.classes
{
    public class Professor : Taxa
    {
        public string turma;

        public override void valeRefeicao()
        {
            base.valeRefeicao();
            Console.WriteLine("A taxa para professor é de 10%");
        }
    }
}