using System;

namespace DSA.Sorting
{
    public class MaximizeHappiness
    {
        public void Start()
        {
            MaximumHappinessSum([2,3,4,5], 2);
        }

        public long MaximumHappinessSum(int[] happiness, int k) 
        {
            PriorityQueue<int,int> priorityQueue = new PriorityQueue<int, int>();

            for(int i = 0; i < happiness.Length; i++)
            {
                priorityQueue.Enqueue(happiness[i], happiness[i]);

                if(priorityQueue.Count > k)
                {
                    priorityQueue.Dequeue();
                }
            }

            int result = 0;
            int counter = priorityQueue.Count - 1;
            while(priorityQueue.Count > 0)
            {
                result += priorityQueue.Peek() - counter  > 0 ? priorityQueue.Peek() - counter : 0;
                priorityQueue.Dequeue();
                counter--;
            }

            return result;
        }
    }
}
