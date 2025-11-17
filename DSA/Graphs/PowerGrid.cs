using System;

namespace DSA.Graphs
{
    public class PowerGrid
    {
        public void start()
        {
            Console.WriteLine(ProcessQueries(5, [],[[1,1],[2,1],[1,1]]));
        }
        public int[] ProcessQueries(int c, int[][] connections, int[][] queries)
        {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            List<int> result = new List<int>();
            HashSet<int> offlineStations = new HashSet<int>();

            for (int i = 1; i <= c; i++) graph.Add(i, new List<int>());

            for (int i = 0; i < connections.Length; i++)
            {
                if (graph.ContainsKey(connections[i][0]))
                {
                    graph[connections[i][0]].Add(connections[i][1]);
                }
                else
                {
                    var list = new List<int>();
                    list.Add(connections[i][1]);
                    graph.Add(connections[i][0], list);
                }

                if (graph.ContainsKey(connections[i][1]))
                {
                    graph[connections[i][1]].Add(connections[i][0]);
                }
                else
                {
                    var list = new List<int>();
                    list.Add(connections[i][0]);
                    graph.Add(connections[i][1], list);
                }
            }

            foreach (var item in queries)
            {
                if (item[0] == 2)
                {
                    offlineStations.Add(item[1]);
                }
                else if (item[0] == 1)
                {
                    var response = IsStationOnline(graph, offlineStations, item[1]);
                    result.Add(response);
                }
            }

            return result.ToArray();
        }
        
        private int IsStationOnline(Dictionary<int, List<int>> graph, HashSet<int> OfflineStations, int station)
        {
            if (graph.ContainsKey(station) && !OfflineStations.Contains(station))
            {
                return station;
            }

            HashSet<int> visited = new HashSet<int>();
            PriorityQueue<int, int> onlinestations = new PriorityQueue<int, int>();
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(station);

            while (queue.Count != 0)
            {
                int Currstation = queue.Dequeue();
                if (graph.ContainsKey(Currstation))
                {
                    if (!OfflineStations.Contains(Currstation))
                    {
                        onlinestations.Enqueue(Currstation, Currstation);
                    }
                    foreach (var midstation in graph[Currstation])
                    {
                        if (!visited.Contains(midstation)) queue.Enqueue(midstation);
                    }
                    visited.Add(Currstation);
                }
            }

            if (onlinestations.Count > 0) return onlinestations.Dequeue();
            return -1;
        }
    }
}
