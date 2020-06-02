using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace A2
{
    abstract class Persona
    {
        private string _nombre;

        public Persona(string nombre)
        {
            Console.WriteLine("Constructor persona " + nombre);
            this.Nombre = nombre;
        }
        public string Nombre
        {
            set { this._nombre = value; }
            get { return this._nombre; }
        }
        public virtual string saludo()
        {
            return "Hola " + Nombre + " que tal";
        }
    }

    class Empleado : Persona
    {
        public Empleado(string nombre, int sueldo = 0) : base(nombre)
        {
            Console.WriteLine("Constructor empleado " + nombre);

            this.Cargo = "Empleado";
        }
        public int Sueldo { get; set; }
        private string _cargo;
        public string Cargo
        {
            set { this._cargo = value; }
            get { return this._cargo; }
        }
        public override string saludo()
        {
            return "Hola empleado " + Nombre + " ¿Todo bien?";
        }
        public virtual double sueldoNeto()
        {
            return Sueldo * .85;
        }
        public double sueldoAnual()
        {
            return Sueldo * 12;
        }

    }

    class Gerente : Empleado
    {
        public int Bono { get; set; }
        public int Dietas { get; set; }
        public Gerente(string nombre) : base(nombre)
        {
            Console.WriteLine("Constructor gerente " + nombre);

            this.Cargo = "Gerente";

        }

        public Gerente(string nombre, int sueldo) : base(nombre, sueldo) { }
        public Gerente(string nombre, int sueldo, int dietas) : this(nombre, sueldo)
        {
            Dietas = dietas;
        }
        public override string saludo()
        {
            return "Hola Sr. " + Nombre + " ¿Desea alguna cosa?";
        }
        public override double sueldoNeto()
        {
            return base.sueldoNeto() + Dietas;
        }
        public new double sueldoAnual()
        {
            return base.sueldoAnual() + Dietas * 12;
        }
    }

    class Funcionario : Persona
    {
        Queue fila;
        public Funcionario(string nombre) : base(nombre)
        {
            fila = new Queue();
        }
        public void turno(Persona p)
        {
            if (fila.Contains(p))
            {
                throw new Exception("Ya en la fila");
            }
            fila.Enqueue(p);
            Console.WriteLine("Añadido a la fila " + p.Nombre);
        }
        public void atender()
        {
            Persona p = (Persona)fila.Dequeue();
            p.saludo();
            Console.WriteLine("Atendido " + p.Nombre);
        }
    }
}
