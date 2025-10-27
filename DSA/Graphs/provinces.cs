using System;
using DSA.BST;

namespace DSA.Graphs
{
    public class provinces
    {
        int[][] input = [[1, 1, 0], [1, 1, 0], [0, 0, 1]];
        public void Start()
        {
            Console.WriteLine(province(input));
        }

        private int province(int[][] connected)
        {
            Dictionary<int, List<int>> adjc = new Dictionary<int, List<int>>();

            for (int i = 0; i < connected.Length; i++)
            {
                adjc.Add(i, new List<int>());
            }

            for (int i = 0; i < connected.Length; i++)
            {
                for (int j = 0; j < connected[i].Length; j++)
                {
                    if (i != j && connected[i][j] == 1)
                    {
                        adjc[i].Add(j);
                        adjc[j].Add(i);
                    }
                }
            }

            HashSet<int> visited = new HashSet<int>();
            int province = 0;
            for (int i = 0; i < connected.Length; i++)
            {
                if (visited.Contains(i)) continue;
                province++;

                Queue<int> nodes = new Queue<int>();
                nodes.Enqueue(i);

                while (nodes.Count > 0)
                {
                    var item = nodes.Dequeue();
                    foreach (var node in adjc[item])
                    {
                        if (visited.Contains(node)) continue;

                        visited.Add(node);
                        nodes.Enqueue(node);
                    }
                }
            }
            return province;
        }
    }
}
