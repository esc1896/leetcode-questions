public class Solution {
    public string MakeGood(string s) {
        
        if(string.IsNullOrEmpty(s) || s.Length < 2) return s;
        
        var removed = false;
        do
        {
            var arr = new List<char>();
            var first = 0;
            var second = 1;
            removed = false;
            for(; first < s.Length - 1 && second < s.Length;first++,second++)
            {
                if(Math.Abs(s[first] - s[second])==32)
                {
                    removed = true; 
                    first++;
                    second++;
                }
                else
                {
                    arr.Add(s[first]);
                }            
            }
            if(first == s.Length - 1) arr.Add(s[first]);
            s = new string(arr.ToArray());            
        }while(removed);
        
        return s;        
    }
}
