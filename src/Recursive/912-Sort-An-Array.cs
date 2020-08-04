public class Solution {
    public int[] SortArray(int[] nums) {
        
        if(nums==null || nums.Length<=1) return nums;
        
        // bubble 
        
        
        // insert
        
        
        // select
        /*
        for(int i = 0; i < nums.Length; i++)
        {
            var index = i;
            for(int j = i+1; j< nums.Length;j++)
            {
                if(nums[j] < nums[index]) index = j;
            }
            if(index != i)
            {
                var tmp = nums[i];
                nums[i] = nums[index];
                nums[index] = tmp;
            }
        }
        return nums;
        */
        
        // merge
        var rst = mergeSort(nums, 0, nums.Length-1);
        return rst;
        
        // quick
        //quickSort(nums, 0, nums.Length-1);
        //return nums;
        
        // bucket
    }
    
    private int[] mergeSort(int[] src, int start, int end)
    {
        if(start == end)
        {
            var rst1 = new int[1];
            rst1[0] = src[start];
            return rst1;
        }
        if(end == start + 1)
        {
            var rst2 = new int[2];
            if(src[end] > src[start])
            {
                rst2[0] = src[start];
                rst2[1] = src[end];
            }
            else
            {
                rst2[0] = src[end];
                rst2[1] = src[start];
            }
            return rst2;
        }
            
        var middle = (end - start)/2 + start;
        
        var first = mergeSort(src, start, middle);
        var second = mergeSort(src, middle+1, end);
        
        var rst = merge(first, second);
        return rst;
    }
    
    private int[] merge(int[] first, int[] second)
    {
        var rst = new int[first.Length+second.Length];
        
        var sI = 0;
        var fI = 0;
        for(;fI<first.Length && sI<second.Length;)
        {
            if(first[fI] < second[sI])
            {
                rst[fI+sI] = first[fI];
                fI++;
            }
            else
            {
                rst[fI+sI] = second[sI];
                sI++;
            }
        }
        
        var remain = first;
        var remainI = fI;
        if(sI < second.Length)
        {
            remain = second;
            remainI = sI;
        }
        
        for(;remainI < remain.Length;remainI++)
        {
            rst[rst.Length - remain.Length + remainI] = remain[remainI];
        }
        
        return rst;
    }
    
    private void quickSort(int[] src, int start, int end)
    {
        if(start < 0 || end >= src.Length || start >= end) return;
        var pivot = partion(src, start, end);
        quickSort(src, start, pivot-1);
        quickSort(src, pivot+1, end);
    }
    
    private int partion(int[] src, int start, int end)
    {
        var pivotEle = src[end];
        var i = start;
        var j = start;
        for(; i <= end && j<=end;j++)
        {
            if(src[j] <= pivotEle)
            {
                var tmp = src[i];
                src[i] = src[j];
                src[j] = tmp;
                i++;
            }
        }
        return i-1;
    }
}
