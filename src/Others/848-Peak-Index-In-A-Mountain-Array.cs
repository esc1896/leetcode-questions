// Runtime: 104 ms
// Memory usage: 24.5 MB

public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        int len = A.Length;
        int i = 0;
        for(; i < len-1; i++){
            if(A[i] > A[i+1])
                break;                
        }
        return i;
    }
}

// O(logN)

public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        int len = A.Length;
        int index = 0, left = 0, right = len - 1;
        
        while(left < right){
            
            index = (left + right)/2;
            
            if(A[index] <= A[index + 1]) 
                left = index;
            else if(A[index] <= A[index - 1]) 
                right = index;
            else break;            
        } 

        return index;
    }
}