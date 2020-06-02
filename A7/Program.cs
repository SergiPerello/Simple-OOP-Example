using System;
using System.Collections.Generic;

namespace A7
{
    class Program
    {
        static void Main(string[] args)
        {
            Programa p = new Programa();

            p.add(new Tarea("comprovar el avión", "Guillem Soler", 20));
            p.add(new Tarea("comprovar el camión", "Eduard Serra", 40));
            Console.WriteLine(p.tiempo());
            p.ToString();
            Console.ReadKey();
        }
    }
}
