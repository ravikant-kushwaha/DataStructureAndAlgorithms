using System;
using System.Text;

namespace DSA.Recrusion
{
    public class NQueen
    {
        public void Start()
        {
            Queen(4);
        }

        private void Queen(int n)
        {
            bool[][] board = new bool[n][]; // Create a 2D array of size n*n
            for (int i = 0; i < n; i++)
            {
                board[i] = new bool[n]; // Initialize each row of the board
            }

            IList<IList<string>> result = new List<IList<string>>();
            var output = queens(board, 0, result);
            Console.ReadKey();
        }


        public static IList<IList<string>> queens(bool[][] board, int row, IList<IList<string>> result)
        {
            if (row == board.Length)  // it means all the queens has been placed
            {
                IList<string> current = new List<string>();
                for (int i = 0; i < board.Length; i++)
                {
                    string s = "";
                    for (int j = 0; j < board[i].Length; j++)
                    {
                        if (board[i][j] == true)
                            s += "Q";
                        else
                            s += ".";
                    }
                    current.Add(s);
                }
                result.Add(current); // Add the current arrangement to the result list
                return result;
            }

            // Placing the queen and checking for every row and columns
            for (int col = 0; col < board.Length; col++)
            {
                // Place the queen if it is safe
                if (isSafe(board, row, col))
                {
                    board[row][col] = true; // Mark this cell as true (queen is placed here)
                    queens(board, row + 1, result); // Call the function for next row
                    board[row][col] = false; // Backtrack and mark this cell as false
                }
            }

            return result; // Return the result list containing all arrangements

        }

        private static bool isSafe(bool[][] board, int row, int col)
        {
            // Check for vertical row
            for (int i = 0; i < row; i++)
            {
                if (board[i][col] == true)
                    return false;   // If there is a queen in the same column thne it is not safe. so return false
            }

            // Check for Diagonal left
            int maxLeft = Math.Min(row, col);
            for (int i = 0; i <= maxLeft; i++)
            {
                if (board[row - i][col - i] == true)
                    return false;   // If there is a queen in the same diagonal then it is not safe. so return false
            }

            // Check for Diagonal right
            int maxRight = Math.Min(row, board.Length - col - 1);
            for (int i = 0; i <= maxRight; i++)
            {
                if (board[row - i][col + i] == true)
                    return false;   // If there is a queen in the same diagonal then it is not safe. so return false
            }

            return true; // If there is no queen in the same column or diagonal then it is safe to place the queen
        }

    }
}
