using System;
using System.Collections.Generic;
using System.Text;

namespace A3
{
    class Comic:Publicacion
    {
        public string Author { get; set; }

        public decimal pvp()
        {
            return precio * 1.1;
        }
    }
}
