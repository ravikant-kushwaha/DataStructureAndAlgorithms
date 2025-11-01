using System;
using Microsoft.VisualBasic;

namespace DSA.LinkedList
{
    public class DeleteNodes
    {
        public ListNode ModifiedList(int[] nums, ListNode head) 
        {
            HashSet<int> hash = new HashSet<int>();

            foreach (var item in nums) hash.Add(item);

            ListNode dummy = new ListNode();
            dummy.next = head;
            ListNode curr = dummy.next;
            ListNode prev = dummy;
            while(curr != null)
            {
                if (hash.Contains(curr.val))
                {
                    prev.next = curr.next;
                    curr = curr.next;
                }
                else
                {                  
                    prev = curr;
                    curr = curr.next;
                }
            }
            return dummy.next;
        }
    }
}
