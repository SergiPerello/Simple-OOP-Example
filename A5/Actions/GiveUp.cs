using DilemaPrisionero.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero.Actions
{
    class GiveUp : IAction
    {
        public int getAction()
        {
            return 1;
        }
    }
}
