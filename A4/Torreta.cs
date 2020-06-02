using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace A4
{
    class Torreta : IGiros
    {
        ArrayList HistorialGiros = new ArrayList();

        public string girarDerecha()
        {
            HistorialGiros.Add("D");
            return "Giramos la Torreta a la Derecha";
        }

        public string girarIzquierda()
        {
            HistorialGiros.Add("I");
            return "Giramos la Torreta a la Izquierda";
        }
        public int Orientacion()
        {
            int grados = 0;
            foreach (string move in HistorialGiros)
            {
                if (move == "D")
                {
                    grados += 90;
                }
                if (move == "I")
                {
                    grados -= 90;
                }
                grados = grados % HistorialGiros.Count;
            }
            return grados;
        }
    }
}
