using System;

namespace ConsoleApp1
{
    public class TennisGame2 : ITennisGame
    {
        private int p1point;
        private int p2point;

        private string p1res;
        private string p2res;
        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string GetScore (string score, int point)
        {
            if (point == 0)
                score = "Love";
            if (point == 1)
                score = "Fifteen";
            if (point == 2)
                score = "Thirty";
            if (point == 3)
                score = "Forty";
            return score;
        }

        public string GetScore()
        {
            var score = "";

            if (p1point == p2point)
            {
                score = (p1point < 3) ? GetScore(score, p1point) + "-All" : "Deuce";
            }
            else
            {
                //if (Math.Abs(p1point - p2point) == Math.Max(p1point, p2point))
                //{

                //}

                if (p1point > 0 && p2point == 0)
                {
                    p1res = GetScore(p1res, p1point);

                    p2res = "Love";
                    score = p1res + "-" + p2res;
                }
                if (p2point > 0 && p1point == 0)
                {
                    p2res = GetScore(p2res, p2point);

                    p1res = "Love";
                    score = p1res + "-" + p2res;
                }

                if (p1point > p2point && p1point < 4)
                {
                    p1res = GetScore(p1res, p1point);
                    p2res = GetScore(p2res, p2point);
                    score = p1res + "-" + p2res;
                }
                if (p2point > p1point && p2point < 4)
                {
                    p1res = GetScore(p1res, p1point);
                    p2res = GetScore(p2res, p2point);
                    score = p1res + "-" + p2res;
                }

                if (Math.Min(p1point, p2point) > 2)
                {
                    score = (p1point > p2point) ? "Advantage player1" : "Advantage player2";
                }

                if (p1point >= 4 && (p1point - p2point) >= 2)
                {
                    score = "Win for player1";
                }
                if (p2point >= 4 && (p2point - p1point) >= 2)
                {
                    score = "Win for player2";
                }
            }
            return score;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                p1point++;
            else
                p2point++;
        }

    }
}
