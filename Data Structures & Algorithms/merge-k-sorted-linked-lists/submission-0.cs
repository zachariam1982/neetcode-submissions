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
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> queue = new PriorityQueue<ListNode, int>();
        ListNode result = null, ptr = null;

        for(int i = 0; i < lists.Length; i++){
            if(lists[i] != null) queue.Enqueue(lists[i], lists[i].val);
        } 

        if(queue.Count == 0) return null;

        result = queue.Dequeue();
        ptr = result;

        if(result.next != null) queue.Enqueue(result.next, result.next.val);


        while(queue.Count != 0){
            ptr.next = queue.Dequeue();
            ptr = ptr.next;

            if(ptr.next != null) queue.Enqueue(ptr.next, ptr.next.val);
        }

        return result;
    }
}
