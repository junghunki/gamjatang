public class Solution {
    public int MaxAreaOfIsland(int[,] grid) {
        var result = 0;
        var visited = new HashSet<(int, int)>();
        
        for(var i=0; i<grid.GetLength(0); ++i){
            for(var j=0; j<grid.GetLength(1); ++j){
                if(grid[i,j] == 0 || visited.Contains((i,j))){
                    continue;
                }
                var size = LandSize(i, j, grid, visited);
                result = size > result ? size:result;
            }
        }
        return result;
    }
                   
    private int LandSize(int i, int j, int[,] grid, HashSet<(int, int)> visited){
        if(i < 0 || i >= grid.GetLength(0) || 
           j < 0 || j >= grid.GetLength(1) || 
           visited.Contains((i,j)) ||
           grid[i,j] == 0){
            return 0;
        }
        
        visited.Add((i,j));
        
        return 1 + LandSize(i, j-1, grid, visited) 
            + LandSize(i, j+1, grid, visited) 
            + LandSize(i-1, j, grid, visited) 
            + LandSize(i+1, j, grid, visited); 
    }
}
