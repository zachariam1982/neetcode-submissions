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
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null) return head;

        var a = head;
        var b = head.next;
        var ptr = ReverseList(b);
        b.next = a;
        a.next = null;

        return ptr;
    }
}
