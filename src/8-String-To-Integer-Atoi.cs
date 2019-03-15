// First version, could use state machine?
// Runtime: 80 ms
// Memory Usage: 23.7 MB

public class Solution {
    private Dictionary<char,int> dict = new Dictionary<char,int>()
    {
        {'1',1},
        {'2',2},
        {'3',3},
        {'4',4},
        {'5',5},
        {'6',6},
        {'7',7},
        {'8',8},
        {'9',9},
        {'0',0}
    };
    
    public int MyAtoi(string str) {
        
        int rst = 0;
        bool isPositive = true;
        
        // only empty, return 0
        char[] input = str.ToCharArray();
        int len = input.Length;
        if(len == 0) return 0;        
        
        // Remove prefix whitespace
        int index = 0;
        while(index < len && input[index] == ' ')
            index++;        
        if(index == len) return 0;                    
        
        // first char can be +/-
        if(input[index] == '+')
        {
            isPositive = true;
            index++;
        }
        else if(input[index] == '-')
        {
            isPositive = false;
            index++;
        }
        
        // first seq of non-whitespace not valid int, return 0
        if(index >= len ||!dict.Keys.Contains(input[index])) return 0;
        
        // Start to calculate
        for(int i = index; i < len; i++)
        {
            if(!dict.Keys.Contains(input[i]))
            {
                break;
            }
            
            if(isPositive)
            {
                // max and min limit
                if((rst > Int32.MaxValue / 10)
                   ||(dict[input[i]] > Int32.MaxValue - rst * 10))
                {
                    rst = Int32.MaxValue;
                    break;
                }

                rst = rst * 10 + dict[input[i]];                
            }
            else
            {
                if((rst < Int32.MinValue / 10)
                   ||(dict[input[i]] + Int32.MinValue > rst * 10 ))
                {
                    rst = Int32.MinValue;
                    break;
                }

                rst = rst * 10 - dict[input[i]];                                
            }            
        }        
                
        return rst;        
    }
}