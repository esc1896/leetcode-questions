// Runtime: 112 ms
// Memory Usage: 24.4 MB

public class Solution {

    private string handleDiffBit(string ten, string five, string one, int num)
    {
        StringBuilder rst = new StringBuilder();
        switch(num)
        {
            case 9:
                rst.Append(one);
                rst.Append(ten);
                break;
            case 8:
            case 7:
            case 6:
            case 5:
                rst.Append(five);
                while(num - 5 > 0)
                {
                    rst.Append(one);
                    num--;
                }
                break;
            case 4:
                rst.Append(one);
                rst.Append(five);
                break;
            case 3:
            case 2:
            case 1:
                while(num > 0)
                {
                    rst.Append(one);
                    num--;
                }
                break;
            default:
                break;
        }
        
        return rst.ToString();        
    }
    
    public string IntToRoman(int num) {
        
        StringBuilder rst = new StringBuilder();
        
        int thousand = num / 1000;
        while(thousand > 0)
        {
            rst.Append("M");
            thousand--;
        }
        num = num % 1000;
        
        int hundred = num / 100;
        rst.Append(handleDiffBit("M","D","C",hundred));
        num = num % 100;
        
        int ten = num / 10;
        rst.Append(handleDiffBit("C","L","X",ten));
        num = num % 10;
        
        int single = num;
        rst.Append(handleDiffBit("X","V","I",single));
        
        return rst.ToString();
    }
}