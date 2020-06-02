using System;
using System.Collections.Generic;
using System.Text;

namespace A1
{
    class Persona
    {
        public String name
        {
            set
            {
                if (value.Length > 3)
                {
                    this.pName = value;
                }
                else
                {
                    throw new Exception("Empleado.name tiene que ser mas de 3 caracteres");
                }
            }
            get { return pName; }
        }
        private String pName;
        public string saludo()
        {
            return "Hola que tal";
        }

        public Persona(String name = "Anonimo")
        {
            this.name = name;
        }
    }
}
