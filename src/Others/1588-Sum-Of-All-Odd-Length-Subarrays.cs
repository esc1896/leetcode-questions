public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        
        long sum = 0;
        for(var run = 1; run <= arr.Length; run+=2)
        {
            long init = 0;
            for(var i = 0; i < run; i++)
            {
                init += arr[i];                
            }            
            sum += init;
            
            for(var i = run; i < arr.Length; i++)
            {
                init = init - arr[i-run] + arr[i];
                sum += init;
            }            
        }
        
        return (int)sum;
    }
}
