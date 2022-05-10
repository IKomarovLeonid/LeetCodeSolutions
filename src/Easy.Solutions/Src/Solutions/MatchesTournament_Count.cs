using System;
namespace Easy.Solutions.Src.Solutions
{
    public class MatchesTournament_Count
    {
        /*
         * You are given an integer n, the number of teams in a tournament that has strange rules:
         * If the current number of teams is even, each team gets paired with another team.
         * A total of n / 2 matches are played, and n / 2 teams advance to the next round.
         * If the current number of teams is odd, one team randomly advances in the tournament, and the rest gets paired.
         * A total of (n - 1) / 2 matches are played, and (n - 1) / 2 + 1 teams advance to the next round.
         * Return the number of matches played in the tournament until a winner is decided.
         * 
         * 
         * 
         */


        public int NumberOfMatches(int n)
        {
            if (n == 1 || n == 0) return 0;
            if (n == 2) return 1;

            if (n % 2 == 0) return n / 2 + NumberOfMatches(n / 2);

            return 1 + NumberOfMatches(--n);
        }
    }
}
