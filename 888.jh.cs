public class Solution {
    public int[] FairCandySwap(int[] A, int[] B) {
        var sum_a = 0;
        foreach(var i in A){
            sum_a += i;
        }
        
        var sum_b = 0;
        var bset = new HashSet<int>();
        foreach(var b in B){
            bset.Add(b);
            sum_b += b;
        }
        
        var target = sum_a - sum_b;
        
        foreach(var a in A){
            if(bset.Contains(a - target/2)){
                return new[]{a, a - target/2};
            }
        }
        return new int[0];
    }
}
