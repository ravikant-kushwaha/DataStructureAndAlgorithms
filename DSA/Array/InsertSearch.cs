using System;

namespace DSA.Array
{
    public class InsertSearch
    {
        public void Start()
        {
            Console.WriteLine(SearchInsert([1, 3, 5, 6, 7], 8));
        }
        public int SearchInsert(int[] nums, int target)
        {
            return index(nums, 0, nums.Length - 1, target);
        }

        private int index(int[] nums, int left, int right, int target)
        {
            if (left > right) return right + 1;
            int mid =  (right + left) / 2;
            if (nums[mid] == target) return mid;
            if (target > nums[mid])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
            return index(nums, left, right, target);
        }
        
    }
}
