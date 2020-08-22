public class Solution {
    public int[] SortArrayByParity(int[] A) {
        
        int even = 0;
        int odd = A.Length - 1;
        for(;even < odd;)
        {
            while(even <= A.Length-1 && A[even]%2==0)
            {
                even++;
            }
            while(odd >= 0 && A[odd]%2==1)
            {
                odd--;
            }
            if(even >= odd) break;
            
            var tmp = A[even];
            A[even] = A[odd];
            A[odd]=tmp;
            
            even++;
            odd--;
        }
        return A;
    }
}
