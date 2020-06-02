using DilemaPrisionero.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero
{
    class CLI:IOutput
    {

        public void showMoney(List<Player> players)
        {
            foreach (Player p in players)
            {
                Console.WriteLine("{0}|{1}",
                    p.name, p.score);
            }
        }
    }
}
