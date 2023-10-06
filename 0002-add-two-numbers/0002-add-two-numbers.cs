/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        //dummy node
        ListNode sentinel = new ListNode(0);

        //pointers
        ListNode p = l1;
        ListNode q = l2;
        ListNode current = sentinel;

        //carryover
        int carry = 0;

        //Manually iterate over both linked lists
        while(p != null || q != null)
        {
            //extracted values from nodes into value1 & value2
            int value1 = (p != null) ? p.val : 0;
            int value2 = (q != null) ? q.val : 0;

            //Add extracted values and carry together
            int sum = carry + value1 + value2;

            //isolate tens position
            carry = sum / 10;

            //capture and store ones position in new node
            current.next = new ListNode(sum % 10);

            //Increment current position
            current = current.next;

            //Increment list pointers
            if(p != null)
            {
                p = p.next;
            }

            if(q != null)
            {
                q = q.next;
            }
        }

        //if carry > 0, created new node with it's value to that of carry
        if(carry > 0)
        {
            current.next = new ListNode(carry);
        }

        //return new linked list without the dummy node
        return sentinel.next;
    }
}