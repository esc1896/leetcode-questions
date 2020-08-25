public class Solution {
    
    bool[][] visited;
    int[] dx = new int[]{-1, 1, 0, 0};
    int[] dy = new int[]{0, 0, -1, 1};
    int row;
    int col;
    
    public bool ContainsCycle(char[][] grid) {
        
        row = grid.Length;
        col = grid[0].Length;
        visited = new bool[row][];        
        for(int i = 0; i < row; i++)
        {
            visited[i] = new bool[col];            
        }                
        
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                if(visited[i][j]) continue;
                if(dfsHasCycle(i,j, -1, -1, grid)) 
                    return true;                
            }            
        }
        
        return false;        
    }
    
    private bool dfsHasCycle(int x, int y, int px, int py, char[][] grid)
    {
        for(int i = 0; i < 4; i++)
        {
            var nx = x + dx[i];
            var ny = y + dy[i];
            
            if(nx < 0 || nx >= row || ny < 0 || ny >= col || (nx == px && ny == py)) continue;                        
            if(grid[nx][ny] != grid[x][y]) continue;
            
            //Console.WriteLine($"{nx} {ny} {x} {y} {grid[x][y]} {visited[nx][ny]}");
            
            if(visited[nx][ny]) return true;
            
            visited[nx][ny] = true;                                    
            if(dfsHasCycle(nx, ny, x, y, grid)) 
                return true;
        }
        
        return false;        
    }
}
