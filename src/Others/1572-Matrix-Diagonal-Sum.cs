public class Solution {
    public int DiagonalSum(int[][] mat) {
        
        var sum = 0;        
        
        for(int i = 0; i < mat.Length; i++)
        {
            sum += mat[i][i];
            sum += mat[i][mat.Length-1-i];            
        }
        
        if(mat.Length%2 == 1)
            sum -= mat[mat.Length/2][mat.Length/2];
        
        return sum;
    }
}
