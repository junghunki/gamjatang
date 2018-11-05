// https://leetcode.com/problems/n-ary-tree-preorder-traversal/description/
public class _589_n-ary-tree-preorder-traversal {
   public List<Integer> preorder(Node root) {
        List<Integer> res = new ArrayList();
	dfs(res, root);
	return res;
    }
	
    private void dfs(List<Integer> res, Node root) {
	if (root == null) return;

	res.add(root.val);
	for (Node child : root.children) {
		dfs(res, child);
	}
    }
}
