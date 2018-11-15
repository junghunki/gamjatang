public class Solution {
    public int[] ShortestToChar(string S, char C) {
        var targets = new List<int>();
        var output = new int[S.Length];
        
        for(var i=0; i<S.Length; ++i){
            if(S[i] == C){
                targets.Add(i);
            }
        }
        
        var index = 0;
        for(var i=0; i<S.Length; ++i){
            var dist1 = Math.Abs(i - targets[index]);
            output[i] = dist1;
            if(index+1 < targets.Count){
                var dist2 = Math.Abs(i - targets[index+1]);
			      if(dist1 > dist2){
                    index++;
			        output[i] = dist2;
                }
            }           
        }
        return output;
    }
}
