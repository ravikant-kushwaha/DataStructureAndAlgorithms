using System;

namespace DSA.Array
{
    public class Rotatematrix
    {
        public void Start()
        {
            Rotate([[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]);
        }
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            int i = 0, j = 0;
            while(i < n/2)
            {
                replace(i, j, matrix);
                i++;
                j++;
            }
        }
        
        private void replace(int i, int j, int[][] matrix)
        {
            int TopLeftRow = i, TopLeftColumn = j;
            int TopRightRow = i, TopRightColumn = matrix[0].Length - j - 1;
            int BottomRightRow = matrix.Length - i -1, BottomRightColumn = matrix[0].Length - j - 1;
            int BottomLeftRow = matrix.Length - i -1, BottomLeftColumn = j;

            while(TopLeftColumn < matrix[0].Length - j - 1)
            {
                int temp = matrix[TopRightRow][TopRightColumn];
                matrix[TopRightRow][TopRightColumn] = matrix[TopLeftRow][TopLeftColumn];
                int temp2 = matrix[BottomRightRow][BottomRightColumn];
                matrix[BottomRightRow][BottomRightColumn] = temp;
                temp = matrix[BottomLeftRow][BottomLeftColumn];
                matrix[BottomLeftRow][BottomLeftColumn] = temp2;
                matrix[TopLeftRow][TopLeftColumn] = temp;


                TopLeftColumn++;
                TopRightRow++;
                BottomRightColumn--;
                BottomLeftRow--;
            }
        }
    }
}
