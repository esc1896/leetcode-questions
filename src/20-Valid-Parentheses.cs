// Runtime: 72 ms
// Memory Usage: 19.6 MB

public class Solution {
    public bool IsValid(string s) {
        if(String.IsNullOrEmpty(s)) return true;
        
        bool rst = true;        
        Dictionary<char,char> bracket = new Dictionary<char,char>(){
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };
        
        char[] inputString = s.ToCharArray();
        char[] stack = new char[inputString.Length+1];
        int stackTop = 0;
        for(int i = 0; i < inputString.Length; i++)
        {
            if(bracket.Keys.Contains(inputString[i]))
            {
                stack[stackTop] = inputString[i];
                stackTop++;                    
            }
            else
            {
                if((stackTop < 1)
                ||!bracket.Keys.Contains(stack[stackTop-1])
                ||bracket[stack[stackTop-1]]!=inputString[i])
                {
                    rst = false;
                    break;
                }
                else
                {
                    stackTop--;                    
                }                
            }                
        }
        
        if(stackTop != 0) rst = false;
        
        return rst;        
    }
}