using System;
using System.Collections;

namespace DSA.Graphs
{
    public class ConnectedComputers
    {
        int[][] input = [[0, 1], [0, 2], [0, 3], [1, 2]];
        public void Start()
        {
            Console.WriteLine(ConnectedComputer(6, input));
        }

        private int ConnectedComputer(int n, int[][] connections)
        {
            Dictionary<int, List<int>> adjc = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
                adjc.Add(i, new List<int>());

            foreach (var item in connections)
            {
                adjc[item[0]].Add(item[1]);
                adjc[item[1]].Add(item[0]);
            }

            int Graphs = 0;

            HashSet<int> visited = new HashSet<int>();
            Queue<int> unvisited = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                if (visited.Contains(i)) continue;

                Graphs++;

                unvisited.Enqueue(i);

                while (unvisited.Count > 0)
                {
                    var currNode = unvisited.Dequeue();
                    foreach (var item in adjc[currNode])
                    {
                        if (visited.Contains(item)) continue;
                        unvisited.Enqueue(item);
                    }
                    visited.Add(currNode);
                }
            }

            return Graphs <= connections.Length - 1 ? Graphs - 1 : -1;
        }
    }
}
