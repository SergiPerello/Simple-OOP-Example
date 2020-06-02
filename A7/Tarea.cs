using System;
using System.Collections.Generic;
using System.Text;

namespace A7
{
    public class Tarea
    {
        public string name { get; set; }
        public string encargado { get; set; }
        public int horas { get; set; }

        public Tarea(string name, string encargado, int horas)
        {
            this.name = name; this.encargado = encargado; this.horas = horas;
        }

        public override string ToString()
        {
            return name + " - " + encargado + " - " + horas;
        }
    }
}
