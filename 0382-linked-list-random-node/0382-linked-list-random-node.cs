public class Solution {
    List<ListNode> lists = new List<ListNode>();

    public Solution(ListNode head) {
        BreakSolution(head);
    }

    public void BreakSolution(ListNode head) {
        lists.Add(head);
        if(head.next != null) BreakSolution(head.next);
    }

    public int GetRandom() {
        Random rnd = new Random();
        int RndIdx = rnd.Next(0, lists.Count);
        return lists[RndIdx].val;
    }
}