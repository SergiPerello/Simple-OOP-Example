using System;
using System.Collections.Generic;
using System.Text;

namespace A3
{
    abstract class Publicacion
    {
        public string Title { get; set; }
        public decimal Precio { get; set; }

        public abstract decimal Pvp();
    }
}
