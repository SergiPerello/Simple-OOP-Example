using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A7
{
    public class Programa
    {
        Queue<Tarea> Tareas = new Queue<Tarea>();

        public void add(Tarea t)
        {
            Tareas.Enqueue(t);
        }

        public string procesar()
        {
            return Tareas.Dequeue().ToString();
        }

        public int tiempo()
        {
            int suma = 0;
            foreach(Tarea item in Tareas)
            {
                suma += item.horas;
            }
            return suma;
        }

        public void optimizar()
        {
            Tareas = new Queue<Tarea>(Tareas.OrderBy(el => el.horas));
        }

        public override string ToString()
        {
            return String.Join(" - ", Tareas);
        }
            
    }
}
