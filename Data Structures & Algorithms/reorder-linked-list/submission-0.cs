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
    public void ReorderList(ListNode head) {
        List<ListNode> lst = new List<ListNode>();
        var ptr = head;
        int i = 0,j = 0;

        while(ptr != null){
            lst.Add(ptr);
            ptr = ptr.next;
        }

        int start = lst.Count() - 1, end = start / 2;

        for(i = 0, j = lst.Count() - 1; i < j; i++, j--){
            lst[i].next = lst[j];
            lst[j].next = lst[i + 1];
            lst[i + 1].next = null;
        }
        lst[i].next = null;

        return;
    }
}
