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
        List<int> output = new List<int>();
        for(int i = 0; i<lists.Count(); i++) {
            ListNode head = lists[i];
            while(head != null) {
                output.Add(head.val);
                head = head.next;
            }
        }

        if(output.Count() == 0) return null;

        output.Sort();
        ListNode outputList = new ListNode();
        ListNode tmp = outputList;
        for(int i = 0; i<output.Count(); i++) {
            tmp.val = output[i];
            if(i<output.Count()-1) {
                tmp.next = new ListNode();
                tmp = tmp.next;
            }
        }
        return outputList;
    }
}