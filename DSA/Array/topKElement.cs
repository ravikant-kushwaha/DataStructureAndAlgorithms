using System;

namespace DSA.Array
{
    public class topKElement
    {
        int[] input = [1, 1, 1, 2, 2, 3];
        public void Start()
        {
            Topk(input, 2);
        }

        private void Topk(int[] arr, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i])) dict[arr[i]]++;
                else dict.Add(arr[i], 1);
            }

            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => a.CompareTo(b)));

            foreach (var item in dict)
            {
                priorityQueue.Enqueue(item.Key, item.Value);

                if (priorityQueue.Count > k) priorityQueue.Dequeue();
            }

            while (priorityQueue.Count != 0)
            {
                var item = priorityQueue.Dequeue();
                Console.WriteLine(item);
            }

        }
    }
}
