// Runtime: 76 ms
// Memory Usage: 21.4 MB

public class Solution {
    public int LongestValidParentheses(string s) {
        
        if(String.IsNullOrEmpty(s) || s.Length == 1) return 0;
        
        int rst = 0;        
        char[] array = s.ToCharArray();
        int len = array.Length;
        Stack<int> st = new Stack<int>();
        
        for(int i = 0; i < len; i++)
        {
            if(st.Count == 0) st.Push(i);                
            else if(array[i] == '(') st.Push(i);
            else if(array[i] == ')')
            {                
                if(array[st.Peek()] == '(') st.Pop();
                else st.Push(i);
            }            
        }
        
        if(st.Count == 0) rst = len;
        int high = len, low = 0;
        while(st.Count != 0)
        {
            low = st.Pop();
            rst = (high - low - 1) > rst ? (high - low - 1) : rst;
            high = low;            
        }
        // Compare with zero
        rst = high > rst ? high : rst;
                        
        return rst;
    }
}