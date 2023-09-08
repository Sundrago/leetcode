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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> leafs1 = new List<int>();
        List<int> leafs2 = new List<int>();

        GetLeafs(root1, leafs1);
        GetLeafs(root2, leafs2);

        if(leafs1.SequenceEqual(leafs2)) return true;
        else return false;
    }

    void GetLeafs(TreeNode target, List<int> leafs) {
        if(target.left == null && target.right == null) leafs.Add(target.val);
        if(target.left != null) GetLeafs(target.left, leafs);
        if(target.right != null) GetLeafs(target.right, leafs);
    }
}