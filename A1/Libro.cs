using System;
using System.Collections.Generic;
using System.Text;

namespace A1
{
    class Libro:Publicacion
    {
        public String author
        {
            set
            {
                if (value.Length > 3) this.pAuthor = author;
                else throw new Exception("El nom del autor ha de tenir mes de 3 caracters");
            }
            get { return pAuthor; }
        }
        private String pAuthor;
        public int pages
        {
            set
            {
                if (value > 3 && value < 10000) this.pPages = value;
                else throw new Exception("Nombre de pagines incorrecte");
            }
            get { return pPages; }
        }
        private int pPages;

        public Libro(String title) : base(title) { }
        public Libro(String title, int pages) : this(title)
        {
            this.pages = pages;
        }
    }
}
