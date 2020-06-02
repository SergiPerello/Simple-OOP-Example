using System;

namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            var empleado1 = new Empleado();
            var empleado2 = new Empleado("Pedro");
            var empleado3 = new Empleado("Pedro", "34626385J");
            var empleado4 = new Empleado("Pedro", "34626385J", 1200);

            var empleado5 = new Empleado();
            Console.WriteLine(empleado5.saludo());

        }
    }
}
