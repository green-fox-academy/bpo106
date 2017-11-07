using System;

namespace ConsoleApp1
{
    public class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                m_score1++;
            else
                m_score2++;
        }

        public string NameScore(string score, int tempScore)
        {
            if (tempScore == 0)
                score += "Love";
            else if (tempScore == 1)
                score += "Fifteen";
            else if (tempScore == 2)
                score += "Thirty";
            else
                score += "Forty";
            return score;
        }

        public string GetStatus(string score, int minusResult)
        {
            score = Math.Abs(minusResult) > 1 ? "Win for" : "Advantage";
            return score + " player" + (minusResult > 0 ? "1" : "2");
        }

        public string GetScore()
        {
            string score = string.Empty;
            if (m_score1 == m_score2)
            {
                score = m_score1 > 2 ? "Deuce" : NameScore(score, m_score1) + "-All";
            }
            else if (m_score1 >= 4 || m_score2 >= 4)
            {
                score = GetStatus(score, m_score1 - m_score2);
            }
            else
            {
                score = NameScore(score, m_score1);
                score = NameScore(score += "-", m_score2);
            }
            return score;
        }
    }
}