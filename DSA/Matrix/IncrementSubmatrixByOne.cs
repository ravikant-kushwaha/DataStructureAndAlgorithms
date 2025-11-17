using System;

namespace DSA.Matrix
{
    public class IncrementSubmatrixByOne
    {
        public void Start()
        {
            RangeAddQueriesFast(3, [[1,1,2,2],[0,0,1,1]]);
        }

        public int[][] RangeAddQueries(int n, int[][] queries)
        {
            int[][] matrix = new int[n][];
            for(int i =0; i < n; i++) matrix[i] = new int[n];

            for(int i = 0; i < queries.Length; i++)
            {
                matrix = fillmatrix(queries[i][0], queries[i][1], queries[i][2], queries[i][3], matrix);
            }
            return matrix;
        }

        private int[][] fillmatrix(int topleft, int topright, int bottomleft, int bottomright, int[][] matrix)
        {
            for(int i = topleft; i <= bottomleft; i++)
            {
                for(int j = topright; j <= bottomright; j++)
                {
                    matrix[i][j] += 1;
                }
            }
            return matrix;
        }
   
   
        public int[][] RangeAddQueriesFast(int n, int[][] queries) {
        int[][] diff = new int[n][];
        for (int i = 0; i < n; i++)
            diff[i] = new int[n];

        // Apply difference updates
        foreach (var q in queries)
        {
            int r1 = q[0], c1 = q[1], r2 = q[2], c2 = q[3];

            diff[r1][c1] += 1;
            if (c2 + 1 < n) diff[r1][c2 + 1] -= 1;
            if (r2 + 1 < n) diff[r2 + 1][c1] -= 1;
            if (r2 + 1 < n && c2 + 1 < n) diff[r2 + 1][c2 + 1] += 1;
        }

        // Compute prefix sum
        int[][] result = new int[n][];
        for (int i = 0; i < n; i++)
            result[i] = new int[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int val = diff[i][j];
                if (i > 0) val += result[i - 1][j];
                if (j > 0) val += result[i][j - 1];
                if (i > 0 && j > 0) val -= result[i - 1][j - 1];
                result[i][j] = val;
            }
        }

        return result;
    }
   
    }
}
