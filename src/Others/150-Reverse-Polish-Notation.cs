// Runtime: 100 ms
// Memory Usage: 23.3 MB

public class Solution {
    public int EvalRPN(string[] tokens) {
        
        int len = tokens.Length;
        if(len == 0) return 0;        
        
        Stack<int> st = new Stack<int>();
        
        for(int i = 0; i < len; i++)
        {
            if(tokens[i] == "+")
            {
                int b = st.Pop();
                int a = st.Pop();
                st.Push(a + b);
            }
            else if(tokens[i] == "-")
            {
                int b = st.Pop();
                int a = st.Pop();
                st.Push(a - b);
            }
            else if(tokens[i] == "*")
            {
                int b = st.Pop();
                int a = st.Pop();
                st.Push(a * b);
            }
            else if(tokens[i] == "/")
            {
                int b = st.Pop();
                int a = st.Pop();
                st.Push(a/b);
            }
            else
            {
                st.Push(int.Parse(tokens[i]));                
            }                                
        }        
        
        return st.Pop();
    }
}