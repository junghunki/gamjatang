public class Solution {
    public int CountSubstrings(string s) {
        
        var result = 0;
        var n = s.Length;
        
        for(var c=0.0; c<n; c+=0.5){  
            var left = (int)Math.Truncate(c);
            var right = (int)Math.Ceiling(c);
            while(left>=0 && right<n && s[left] == s[right]){
                result++;
                left--;
                right++;
            }
        }
        
        return result;
    }
}
