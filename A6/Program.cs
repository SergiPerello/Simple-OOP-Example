using System;
using System.Collections.Generic;

namespace A6
{
    class Program
    {
        static void Main(string[] args)
        {
            Liga liga = new Liga();
            liga.add("Hola");
            liga.add("Aguacate");
            liga.add("Adios");
            liga.partidos().ForEach(Console.WriteLine);
            
        }
    }
}
