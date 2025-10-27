using System;

namespace DSA.Array
{
    public class MeetingRoom
    {
        public void Start()
        {
            int[,] meetings = new int[,]
            {
                { 0, 30 },
                { 5, 10 },
                { 15, 20 }
            };

            Console.WriteLine(overlap(meetings));
        }

        private bool overlap(int[,] schedule)
        {
             int n = schedule.GetLength(0);

            // Convert to list for sorting
            var intervals = new List<(int start, int end)>();
            for (int i = 0; i < n; i++)
                intervals.Add((schedule[i, 0], schedule[i, 1]));

            // Sort by start time
            intervals.Sort((a, b) => a.start.CompareTo(b.start));

            // Check for overlaps
            for (int i = 0; i < n - 1; i++)
            {
                if (intervals[i].end > intervals[i + 1].start)
                    return false; // overlap exists
            }

            return true; // no overlaps
        }
    }
}
