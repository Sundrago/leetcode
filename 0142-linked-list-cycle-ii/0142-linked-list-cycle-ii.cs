public class Solution {
    List<ListNode> nodes = new List<ListNode>();
    ListNode answer = null;

    public ListNode DetectCycle(ListNode head) {
        AddNodes(head);
        return answer;
    }

    void AddNodes(ListNode head) {
        if(head == null) return;
        nodes.Add(head);
        if(nodes.Contains(head.next)) answer = head.next;
        else {
            if(head.next != null) AddNodes(head.next);
        }
    }
}