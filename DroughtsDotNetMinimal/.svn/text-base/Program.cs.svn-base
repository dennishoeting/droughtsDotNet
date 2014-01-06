using System;
using DroughtsCommon;
using DroughtsImplementation;
using Util;

namespace DroughtsDotNetMinimal {

    public class Program {

        private static void Main(string[] args) {
            Console.WriteLine(Convert.ToString(1 << 63, 2));

            Out.Head("Creating new game!");
            PlayerBase player1 = new HumanPlayer("Dennis");
            PlayerBase player2 = new HumanPlayer("Marcus");
            LocalGame game = new LocalGame(player1, player2);
            game.Start();
            Console.WriteLine(6.GetHashCode());
            Console.ReadLine();
        }
    }
}