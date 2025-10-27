using System;

namespace DSA.Array
{
    public class MoergeSortedArray
    {
        public void Start()
        {
            Merge([2,5,6,0,0,0], 3, [1,2,3], 3);
            Console.WriteLine();
        }
        public void Merge(int[] nums1, int m, int[] nums2, int n) {
            int[] arr = new int[m + n];
            int i = 0, j = 0;
            int k = 0;
            while(i < m || j < n)
            {
                if(i >= m)
                {
                    arr[k] = nums2[j];
                    j++;
                }
                else if(j >= n)
                {
                    arr[k] = nums1[i];
                    i++;
                }
                else if(nums1[i] > nums2[j])
                {
                    arr[k] = nums2[j];
                    j++;
                }
                else
                {
                    arr[k] = nums1[i];
                    i++;
                }
                k++;
            }
            for (int l = 0; l < arr.Length; l++) nums1[l] = arr[l]; 
        }
    }
}
