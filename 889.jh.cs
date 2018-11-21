/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode ConstructFromPrePost(int[] pre, int[] post) {
        var node = new TreeNode(pre[0]);
        var n = pre.Length;
        if(n <= 1){
            return node;
        }
        
        var l = Array.IndexOf(post, pre[1]) + 1;
        node.left = ConstructFromPrePost(pre.Skip(1).Take(l).ToArray(),
                                        post.Skip(0).Take(l).ToArray());
        if(l+1 < n){
        node.right = ConstructFromPrePost(pre.Skip(l+1).Take(n-l).ToArray(),
                                         post.Skip(l).Take(n-l).ToArray());
        }
        return node;
    }
}
