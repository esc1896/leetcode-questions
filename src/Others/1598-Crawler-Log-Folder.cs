public class Solution {
    public int MinOperations(string[] logs) {
        
        var init = 0;
        for(int i = 0; i < logs.Length; i++)
        {
            if(string.Equals(logs[i],"../"))
            {
                init = init > 0? init - 1 : 0;
            }
            else if(!string.Equals(logs[i],"./"))
            {
                init += 1;                
            }        
        }
        
        return init;
    }
}
