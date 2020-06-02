using System;
using System.Collections.Generic;
using System.Text;

namespace A1
{
    class Empleado:Persona
    {
        /*
        public Empleado(String name = "Anonimo") => this.name = name;
        public Empleado(String name, String dni) : this(name) => this.dni = dni;
        public Empleado(String name, String dni, decimal sueldo) : this(name, dni) => this.sueldo = sueldo;

        public String dni
        {
            set { this.pDni = value; }
            get { return pDni; }
        }
        private String pDni;
        */
        public decimal sueldo
        {
            set { this.pSueldo = value; }
            get { return pSueldo; }
        }
        private decimal pSueldo;
    }
}
