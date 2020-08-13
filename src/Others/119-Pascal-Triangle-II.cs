public class Solution {
    public IList<int> GetRow(int rowIndex) {
        
        var rst = new List<int>{1};
        if(rowIndex == 0) return rst;
        
        rst.Add(1);
        if(rowIndex == 1) return rst;
        
        for(int i = 1; i < rowIndex; i++)
        {
            var tmp = new List<int>();
            tmp.Add(1);
            for(int j = 0; j < rst.Count()-1; j++)
            {
                tmp.Add(rst[j] + rst[j+1]);
            }
            tmp.Add(1);
            rst = tmp;
        }
        
        return rst;
    }
}
