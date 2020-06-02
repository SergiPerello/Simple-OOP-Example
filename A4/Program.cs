using System;

namespace A4
{
    class Program
    {
        static void Main(string[] args)
        {
            Torreta t = new Torreta();
            Vehiculo v = new Vehiculo();

            Operario pepe = new Operario(t);
            pepe.trompo();
            Console.WriteLine(t);

        }
    }
}
