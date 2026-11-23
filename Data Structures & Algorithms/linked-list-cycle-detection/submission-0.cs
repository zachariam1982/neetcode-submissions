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
    public bool HasCycle(ListNode head) {
        ListNode singleJump = head, doubleJump = head;

        if(head == null) return false;

        do{
            singleJump = singleJump.next;
            if(singleJump == null) return false;
            doubleJump = doubleJump.next;
            if(doubleJump == null) return false;
            doubleJump = doubleJump.next;
            if(doubleJump == null) return false;
        }while(singleJump != doubleJump);

        return true;
    }
}
