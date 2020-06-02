using System;
using System.Collections.Generic;
using System.Text;

namespace A4
{
    class Vehiculo : IGiros
    {
        public string girarDerecha()
        {
            return "Giramos el vehiculo a la Derecha";
        }

        public string girarIzquierda()
        {
            return "Giramos el vehiculo a la Izquierda";
        }
    }
}
