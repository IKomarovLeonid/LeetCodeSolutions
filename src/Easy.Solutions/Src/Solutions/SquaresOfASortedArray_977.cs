using System;

namespace Easy.Solutions.Solutions
{
    public class SquaresOfASortedArray_977
    {

        //Task: Given an array of integers A sorted in non-decreasing order,
        //return an array of the squares of each number, also in sorted non-decreasing order

        public int[] SortedSquares(int[] A)
        {
            for (int i = 0; i < A.Length; i++) A[i] = A[i] * A[i];
            Array.Sort(A);
            return A;
        }
    }
}
