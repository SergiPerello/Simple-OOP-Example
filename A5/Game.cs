using DilemaPrisionero;
using DilemaPrisionero.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero
{
    class Game
    {
        public int Rondas { get; set; } = 50;
        public IOutput Output { get; set; }
        List<Versus> Matchmaking = new List<Versus>();
        public Game(List<Player> players)
        {
            List<Versus> matchmaking = GenerateVersus(players);
            Match(matchmaking);
            this.Output = new CLI();
            Output.showMoney(players);
        }

        List<Versus> GenerateVersus(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                for (int j = i + 1; j < players.Count; j++)
                {
                    Matchmaking.Add(new Versus(players[i], players[j]));
                }
            }
            return Matchmaking;
        }

        void Match(List<Versus> matchmaking)
        {
            foreach (Versus v in matchmaking)
            {
                for (int i = 0; i < Rondas; i++)
                {
                    v.player1.setAction();
                    v.player2.setAction();
                    Payment p = Payments.Rules[v.player1.action, v.player2.action];
                    v.player1.score += p.player1;
                    v.player2.score += p.player2;
                }
            }
        }
    }

    public struct Versus
    {
        public Player player1;
        public Player player2;
        public Versus(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
    }
}
