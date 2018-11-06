public class Solution {
    public IList<int> Preorder(Node root) {
        var results = new List<int>();
        
        if(root != null){
            results.Add(root.val);
            foreach(var child in root.children){
                results.AddRange(Preorder(child));
            }
        }
        return results;
    }
}
