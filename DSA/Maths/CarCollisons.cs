using System;

namespace DSA.Maths
{
    public class CarCollisons
    {
        public void Start()
        {
            CountCollisions("RLRSLL");
        }
        public int CountCollisions(string directions) 
        {
            Stack<char> stackDirection = new Stack<char>();
            int Collisions = 0;
            foreach(var item in directions)
            {
                if(item == 'R')
                {
                    while(stackDirection.Count > 0 && stackDirection.Peek() == 'R') stackDirection.Pop();
                }
                else if(item == 'L')
                {
                    while(stackDirection.Count > 0 && stackDirection.Peek() == 'L') stackDirection.Pop();
                }

                if(stackDirection.Count == 0)
                {
                    stackDirection.Push(item);   
                    continue;                
                }

                if(stackDirection.Peek() == 'L' && item == 'R')
                {
                    Collisions += 2;
                    stackDirection.Pop();

                }
                else if(stackDirection.Peek() == 'R' && item == 'L')
                {
                    Collisions += 2;
                    stackDirection.Pop();
                }
                else if(stackDirection.Peek() == 'S' && item == 'L')
                {
                    Collisions += 1;
                }
                else if(stackDirection.Peek() == 'R' && item == 'S')
                {
                    Collisions += 1;
                    stackDirection.Pop();
                    stackDirection.Push('S');
                }
                else
                {
                    stackDirection.Push(item);
                }
            }
            return Collisions;
        }
    }
}
