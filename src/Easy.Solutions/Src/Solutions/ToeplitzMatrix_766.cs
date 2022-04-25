namespace Easy.Solutions.Solutions
{
    public class ToeplitzMatrix_766
    {
        //A matrix is Toeplitz if every diagonal from top-left to bottom-right has the same element.
        //Now given an M x N matrix, return True if and only if the matrix is Toeplitz.

        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int rows = 0;
            while (rows < matrix.Length)
            {
                for (int index = 0; index < matrix[rows].Length; index++)
                {
                    int x = rows + 1;
                    int y = index + 1;
                    if (x < matrix.Length && y < matrix[x].Length)
                    {
                        if (matrix[rows][index] != matrix[x][y]) return false;
                    }

                }
                rows++;
            }

            return true;

        }
    }
}
