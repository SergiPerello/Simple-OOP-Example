using DilemaPrisionero.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero.Actions
{
    class Arbitrary:IAction
    {
        Random r = new Random();
        public int getAction()
        {
            return r.Next(2);
        }
    }
}
