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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var ptr = new ListNode();
        var first = ptr;
        var second = ptr;

        ptr.next = head;

        while(n != 0){
            second = second.next;
            n--;
        }

        if(n != 0 || second == null) return  null;

        while(second.next != null){
            first  = first.next;
            second = second.next;
        }

        first.next = first.next?.next;

        return ptr.next;
    }
}
