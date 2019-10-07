// Runtime: 104 ms
// Memory: 26.6 MB

public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
        
        if(matrix.Length == 0) return false;
        if(matrix.Length == 1) return true;
        
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        if (rows == 1 || cols == 1) return true;
        
        bool result = true;
        for(int row = 1; row < rows; row++)
        {
            for(int col = 1; col < cols; col++)
            {
                if(matrix[row][col]!=matrix[row-1][col-1])
                {
                    result=false;
                    break;
                }
            }
        }
            
        return result;
    }
}