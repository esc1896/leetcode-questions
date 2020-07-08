public class Solution {
    public int IslandPerimeter(int[][] grid) {
        
        if(grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;
        
        int perimeter = 0;
        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                if(grid[row][col] == 1)
                {
                    perimeter += col == 0 || grid[row][col-1] == 0 ? 1 : 0;
                    perimeter += col == grid[0].Length - 1 || grid[row][col+1] == 0 ? 1 : 0;
                    
                    perimeter += row == 0 || grid[row-1][col] == 0 ? 1 : 0;
                    perimeter += row == grid.Length - 1 || grid[row+1][col] == 0 ? 1 : 0;
                }
            }            
        }
        
        return perimeter;
    }
}
