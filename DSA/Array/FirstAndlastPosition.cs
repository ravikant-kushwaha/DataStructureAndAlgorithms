using System;

namespace DSA.Array
{
    public class FirstAndlastPosition
    {
        public void Start()
        {
            Console.WriteLine(SearchInsert([5,7,7,8,8,10], 8));
        }
        public int[] SearchInsert(int[] nums, int target)
        {
            return index(nums, 0, nums.Length - 1, target);
        }

        private int[] index(int[] nums, int left, int right, int target)
        {
            if (left > right) return new int[] { -1, -1};
            int mid =  (right + left) / 2;
            if (nums[mid] == target)
            {
                left = mid;
                right = mid;
                while (nums[left] == target && left > 0) left--;
                while (nums[right] == target && right < nums.Length) right++;
                return new int[] { left + 1, right - 1 };
            }
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
