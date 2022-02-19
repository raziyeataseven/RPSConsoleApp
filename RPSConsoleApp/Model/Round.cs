using System;
using System.Collections.Generic;
using System.Text;

namespace RPSConsoleApp.Model
{
    public class Round
    {
        public Round()
        {
            var rnd = new Random();
            int move = rnd.Next(1, 4);
            Move = (Move)move;

            switch (Move)
            {
                case Move.Paper:
                    Status = Status.Win;
                    break;
                case Move.Rock:
                    Status = Status.Scoreless;
                    break;
                case Move.Scissor:
                    Status = Status.Lose;
                    break;
                default:
                    break;
            }
        }
        public readonly Move Move;
        public readonly Status Status;
    }

    public enum Move
    {
        Rock = 1,
        Paper = 2,
        Scissor = 3
    }

    public enum Status
    {
        Win,
        Lose,
        Scoreless
    }
}
