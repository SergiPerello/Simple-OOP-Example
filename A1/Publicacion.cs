using System;
using System.Collections.Generic;
using System.Text;

namespace A1
{
    class Publicacion
    {
        public String title
        {
            set { this.pTitle = value; }
            get { return pTitle; }
        }
        private String pTitle;
        public int year
        {
            set { this.pYear = value; }
            get { return pYear; }
        }
        private int pYear;

        public Publicacion(String title)
        {
            this.title = title;
        }
    }
}
