using RPSConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPSConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Shall we start to play rock, paper, scissors? (Y/N)");
            string command = Console.ReadLine();
            if (command.ToUpper().StartsWith("Y"))
            {
                Console.WriteLine("Player 1   |   Player 2");
                Console.WriteLine("-----------------------");

                var player = new Player();
                player.Rounds = new List<Round>();

                for (var i = 0; i < 100; i++)
                {
                    var round = new Round();                   
                    player.Rounds.Add(round);
                    Console.WriteLine("Rock       |   {0} ({1})", round.Move.ToString(), round.Status.ToString());
                }
                Console.WriteLine("");
                Console.WriteLine("~~~~Game Summary~~~~");
                Console.WriteLine("");
                Console.WriteLine("Player 1   Wins: {0} Loses: {1} ScoreLess: {2}", player.Rounds.Count(f=>f.Status == Status.Lose), player.Rounds.Count(f=>f.Status == Status.Win), player.Rounds.Count(f=>f.Status == Status.Scoreless));
                Console.WriteLine("");
                Console.WriteLine("Player 2   Wins: {0} Loses: {1} ScoreLess: {2}", player.Rounds.Count(f => f.Status == Status.Win), player.Rounds.Count(f => f.Status == Status.Lose), player.Rounds.Count(f => f.Status == Status.Scoreless));

            }
            else
                Console.WriteLine("Maybe next time! :)");

        }
    }
}
