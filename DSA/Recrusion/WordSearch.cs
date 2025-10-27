using System;

namespace DSA.Recrusion
{
    public class WordSearch
    {
        char[][] input = [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']];
        public void Start()
        {
            Console.WriteLine(serach(input, "ABCB"));
        }
        
        private bool serach(char[][] board, string word)
        {
            bool found = false;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        found = dfs(i, j, board, 0, word, new bool[board.Length, board[0].Length]);
                        if (found) return true;
                    }
                }
            }
            return false;
        }

        private bool dfs(int i, int j, char[][] board, int index, string word, bool[,] visited)
        {
            if (i < 0 || i > board.Length - 1 || j < 0 || j > board[0].Length - 1 || index > word.Length) return false;

            if (board[i][j] != word[index] || visited[i, j]) return false;

            if (word.Length - 1 == index) return true;

            visited[i, j] = true;
            bool found = dfs(i + 1, j, board, index + 1, word, visited);
            if (found) return true;
            found = dfs(i - 1, j, board, index + 1, word, visited);
            if (found) return true;
            found = dfs(i, j + 1, board, index + 1, word, visited);
            if (found) return true;
            found = dfs(i, j - 1, board, index + 1, word, visited);
            if (found) return true;

            visited[i, j] = false;
            return false;
        }
    }
}
