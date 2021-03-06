public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
     
        int minDis = Int32.MaxValue;
        int index = -1;
        for(int i = 0; i < points.Length; i++)
        {
            var tmp = Int32.MaxValue;
            if(points[i][0] == x)
            {
                tmp = Math.Abs(points[i][1] - y);            
                
            }
            else if(points[i][1] == y)
            {
                tmp = Math.Abs(points[i][0] - x);
            }
            
            if (minDis > tmp)
            {                    
                index = i;
                minDis = tmp;
            }
        }
        
        return index;
        
    }
}
