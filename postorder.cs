public class Solution {
    public IList<int> Postorder(Node root) {
        var result = new List<int>();
        if(root != null){
            foreach(var child in root.children){
                result.AddRange(Postorder(child));
            }
            
            result.Add(root.val);
        }
        return result;
        
    }
}
