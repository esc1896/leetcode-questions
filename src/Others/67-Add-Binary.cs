public class Solution {
    public string AddBinary(string a, string b) {
        
        int aI = a.Length-1, bI = b.Length-1, carryOver = 0;
        var rst = new List<char>();
        while(aI >= 0 || bI >= 0)            
        {
            if(aI >= 0) carryOver += a[aI--] - '0';
            if(bI >= 0) carryOver += b[bI--] - '0';
            rst.Add((char)(carryOver%2 + '0')); 
            carryOver = carryOver/2;
        }           
        if(carryOver > 0) rst.Add('1');
        rst.Reverse();
        return new string(rst.ToArray());                     
    }
}
