// 64 ms 
// 15.6 MB
public class Solution {
    public int NthUglyNumber(int n)
    {
        var uglyList = new int[n+1];
        uglyList[0] = 1;

        int l2Index = 0;
        int l3Index = 0;
        int l5Index = 0;

        for (int i = 1; i < n; i++)
        {
            long l2 = uglyList[l2Index] * 2;
            long l3 = uglyList[l3Index] * 3;
            long l5 = uglyList[l5Index] * 5;

            long min = l2 > l3
                ? l3 > l5 ? l5 : l3
                : l2 > l5 ? l5 : l2;

            if(min == l2) l2Index++;
            if(min == l3) l3Index++;
            if(min == l5) l5Index++;
            
            uglyList[i] = (int)min;
        }

        return uglyList[n-1];
    }
}
