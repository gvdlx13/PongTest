using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public static class Winner
    {
        public static string winner = "";


        public static void PlayerWins(int player)
        {
            winner = $"Player {player} wins";
        }
    }
}
