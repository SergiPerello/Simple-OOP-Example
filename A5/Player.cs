using DilemaPrisionero.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero
{
    public class Player
    {
        public string name { get; set; }
        public int score { get; set; }
        public int action { get; set; }

        IAction _iAction;
        public Player(string name, IAction iAction)
        {
            this.name = name;
            this._iAction = iAction;
        }

        public void setAction()
        {
            this.action = _iAction.getAction();
        }
    }
}
