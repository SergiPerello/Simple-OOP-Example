using System;
using System.Collections.Generic;
using System.Text;

namespace A6
{
    class Liga
    {
        List<string> Equipos = new List<string>();

        public void add(string equipo)
        {
            if (!Equipos.Contains(equipo))
                Equipos.Add(equipo);
        }

        public void remove(string equipo)
        {
            if (!Equipos.Contains(equipo))
                throw new Exception("No existe, no se puede borrar");
            else
                Equipos.Remove(equipo);
        }

        public List<string> partidos()
        {
            List<string> Versus = new List<string>();

            foreach (var equipo in Equipos)
            {
                foreach (var equipo2 in Equipos)
                {
                    if (!equipo.Equals(equipo2))
                        Versus.Add(equipo + " vs " + equipo2);
                }
            }
            return Versus;
        }
    }
}
