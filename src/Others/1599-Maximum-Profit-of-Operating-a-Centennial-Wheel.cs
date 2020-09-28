public class Solution {
    public int MinOperationsMaxProfit(int[] customers, int boardingCost, int runningCost) {
        
        if(boardingCost * 4 <= runningCost || customers.Length < 1) return -1;
        
        long remainCust = 0;
        
        long max = 0;
        long revenue = 0; 
        int maxIndex = -1;
        
        int rotateCount = 0;
        int custI = 0;
        
        while(remainCust > 0 || custI < customers.Length)
        {
            //Console.WriteLine($"{remainCust} {custI} {max} {maxIndex}");
            remainCust += custI < customers.Length ? customers[custI] : 0;
            
            var cur = remainCust > 4 ? 4 : remainCust;
            remainCust -= cur;
            revenue += cur * boardingCost - runningCost;
            rotateCount++;
            
            if(revenue > max)
            {
                max = revenue;
                maxIndex = rotateCount; 
            }
            
            custI++;
        }
        
        return maxIndex;        
    }
}
