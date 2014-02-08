using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGameKata2.Model
{
    public class Game
    {
        //test to see if commit works
        private int score1 { get; set; }
        private int score2 { get; set; }

        private bool IsDeuce
        {
            get { return ((score1 == 3) && (score2 == 3)); }
        }

        private bool Player1Wins
        {
            get { return (((score1 >= 4) && (score2 < 3)) || ((score1 == 5) && (score2 == 3))); }
        }

        private bool Player2Wins
        {
            get { return (((score2 >= 4) && (score1 < 3)) || ((score2 == 5) && (score1 == 3))); }
        }

        public Game()
        {
            score1 = 0;
            score2 = 0;
        }

        public string GetScore()
        {
            if (Player1Wins)
                return "Player 1 Wins";
            if (Player2Wins)
                return "Player 2 Wins";
            if (IsDeuce)
                return "Deuce";

            return string.Format("{0}, {1}", FormatScore(score1), FormatScore(score2));
        }

        private string FormatScore(int score)
        {
            if (score == 0)
                return "Love";
            else if (score == 1)
                return "15";
            else if (score == 2)
                return "30";
            else if (score == 3)
                return "40";
            else if (score == 4)
                return "Advantage";

            return string.Empty;
        }

        public void AddScoreToPlayer(int id)
        {
            if (id == 1)
                score1++;
            else
                score2++;

            if ((score1 == 4) && (score2 == 4))
            {
                score1--;
                score2--;
            }
        }
    }
}
