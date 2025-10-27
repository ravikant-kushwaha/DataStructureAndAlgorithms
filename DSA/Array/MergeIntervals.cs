using System;

namespace DSA.Array
{
    public class MergeIntervals
    {
        public void Start()
        {
            Console.WriteLine(Merge([[1,4],[4,5]]));
        }
        public int[][] Merge(int[][] intervals)
        {
            int[][] result = new int[intervals.Length][];
            for (int i = 0; i < intervals.Length; i++)
                result[i] = new int[intervals[i].Length];

            var sortedInterval = new List<(int start, int end)>();
            for (int i = 0; i < intervals.GetLength(0); i++)
                sortedInterval.Add((intervals[i][0], intervals[i][1]));

            sortedInterval.Sort((a, b) => a.start.CompareTo(b.start));

            int resultcount = 0;
            result[resultcount][0] = sortedInterval[0].start;
            result[resultcount][1] = sortedInterval[0].end;
            for (int i = 1; i < sortedInterval.Count; i++)
            {
                if (result[resultcount][1] >= sortedInterval[i].start)
                {
                    result[resultcount][0] = Math.Min(result[resultcount][0], sortedInterval[i].start);
                    result[resultcount][1] = Math.Max(result[resultcount][1], sortedInterval[i].end);
                }
                else
                {
                    resultcount++;
                    result[resultcount][0] = sortedInterval[i].start;
                    result[resultcount][1] = sortedInterval[i].end;
                }
            }

            return result.Take(resultcount + 1).ToArray();
        }
    }
}
