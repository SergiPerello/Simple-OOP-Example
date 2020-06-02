using System;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero
{
    public static class Payments
    {
        public static Payment[,] Rules = new Payment[,]
        {
            {new Payment(3,3), new Payment(-5,5) },
            {new Payment(5,-5), new Payment(-1,-1) }
        };
    }

    public struct Payment
    {
        public int player1;
        public int player2;
        public Payment(int player1, int player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
    }
}
