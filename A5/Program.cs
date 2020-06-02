using DilemaPrisionero.Actions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DilemaPrisionero
{
    class Program
    {
        static void Main(string[] args)
        {
            Player panfilo = new Player("Pánfilo",new Cooperate());
            Player maquiavelo = new Player("Maquiavelo", new GiveUp());
            Player tuntun = new Player("Tuntún", new Arbitrary());
            Game battle = new Game(new List<Player>() { panfilo, maquiavelo, tuntun });
        }
    }
}
