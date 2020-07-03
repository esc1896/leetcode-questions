// Runtime: 1148 ms
// Memory Usage: 19.7 MB
public class Solution {
    public bool CheckValidString(string s)
    {
        char[] charArr = s.ToCharArray();
        int len = charArr.Length;
        if (len < 1) return true;

        return isValidString(0, 0, charArr);
    }

    private bool isValidString(int left, int index, char[] arr)
    {

        bool rst = true;

        if (index > arr.Length - 1)
        {
            if (left != 0)
                return false;

            return true; // ? think a while
        }

        if (arr[index] == ')')
        {
            if (left < 1)
                return false;
            left--;
            rst = isValidString(left, index+1, arr);
        }
        else if (arr[index] == '(')
            rst = isValidString(left+1, index+1, arr);
        else
        {
            // * as )
            bool rst2;
            if (left < 1) rst2 = false;
            else {
                rst2 = isValidString(left-1, index+1, arr);
            }
            // * as space
            bool rst1 = isValidString(left, index+1, arr);
            // * as (
            bool rst3 = isValidString(left+1, index+1, arr);

            rst = rst1 || rst2 || rst3;
        }

        return rst;
    }
}