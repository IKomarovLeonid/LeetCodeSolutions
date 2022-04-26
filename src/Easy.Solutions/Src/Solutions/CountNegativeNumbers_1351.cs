using System;
namespace Easy.Solutions.Src.Solutions
{
    public class CountNegativeNumbers_1351
    {
        /*
         * 
         * Given a m x n matrix grid which is sorted in non-increasing order both row-wise and column-wise, 
         * return the number of negative numbers in grid.
         * 
         */


        public int CountNegatives(int[][] grid)
        {
            var count = 0;
            for (var i = 0; i < grid.GetLength(0); i++)
            {
                var row = grid[i];
                for (var j = row.Length - 1; j > -1; j--)
                {
                    if (row[j] < 0) count++;
                    else break;
                }
            }
            return count;
        }
    }
}
