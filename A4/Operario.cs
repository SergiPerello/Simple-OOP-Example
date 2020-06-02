using System;
using System.Collections.Generic;
using System.Text;

namespace A4
{
    class Operario
    {
        IGiros aparato;
        public Operario(IGiros aparato)
        {
            this.aparato = aparato;
        }
        public void trompo()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(this.aparato.girarDerecha());
            }
        }
    }
}
