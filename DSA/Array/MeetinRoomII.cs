using System;

namespace DSA.Array
{
    public class MeetinRoomII
    {
        public void Start()
        {
           int[,] meetings = new int[,]
            {
                { 1, 3 },
                { 3, 5 },
                { 5, 8 },
                { 8, 10 }
            };

            Console.WriteLine(overlap(meetings));
        }

        private int overlap(int[,] schedule)
        {
            int n = schedule.GetLength(0);
            var intervals = new List<(int start, int end)>();
            for (int i = 0; i < n; i++)
                intervals.Add((schedule[i, 0], schedule[i, 1]));


            intervals.Sort((a, b) => a.start.CompareTo(b.start));

            int MaxRoom = 1;
            int maxEndTime = intervals[0].end;

            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            queue.Enqueue(maxEndTime, maxEndTime);
            for (int i = 1; i < n; i++)
            {
                if(queue.Count > 0 && queue.Peek() <= intervals[i].start)
                {
                    queue.Dequeue();
                }
                if (maxEndTime > intervals[i].start)
                {
                    queue.Enqueue(intervals[i].end, intervals[i].end);
                }
                
                MaxRoom = Math.Max(queue.Count, MaxRoom);
                maxEndTime = Math.Max(maxEndTime, intervals[i].end);
            }
            return MaxRoom;
        }
    }
}
