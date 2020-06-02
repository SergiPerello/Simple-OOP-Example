using System;
using System.Collections.Generic;
using System.Text;

namespace A1
{
    class Magazine:Publicacion
    {
        public int number
        {
            set { this.pNumber = value; }
            get { return pNumber; }
        }
        private int pNumber;
        public int month
        {
            set { this.pMonth = value; }
            get { return pMonth; }
        }
        private int pMonth;

        public Magazine(String title) : base(title) { }
    }
}
