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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    List<int> list = new List<int>();

    public TreeNode SortedListToBST(ListNode head) {
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }

        TreeNode output = new TreeNode();
        if(list.Count == 0) return null;
        AddTreeNode(output, 0, list.Count-1);
        return output;
    }

    void AddTreeNode(TreeNode target, int fromIdx, int toIdx) {
        int count = toIdx - fromIdx +1;
        if(count >= 3) {
            int mid = (int)Math.Floor((fromIdx + toIdx)/2f);
            target.val = list[mid];
            target.left = new TreeNode();
            target.right = new TreeNode();
            AddTreeNode(target.left, fromIdx, mid-1);
            AddTreeNode(target.right, mid+1, toIdx);
        } else if(count == 2) {
            if(list[fromIdx] > list[fromIdx+1]) {
                target.val = list[fromIdx];
                target.left = new TreeNode(list[fromIdx+1]);
            } else {
                target.val = list[fromIdx+1];
                target.left = new TreeNode(list[fromIdx]); 
            }
        } else {
            target.val = list[fromIdx];
        }
    }
}