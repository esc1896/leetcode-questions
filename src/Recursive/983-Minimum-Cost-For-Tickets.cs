// solution 1
public class Solution {
    
    int[] cost;
    int[] intervals = new int[]{1,7,30};
    
    public int MincostTickets(int[] days, int[] costs) {
        
        cost = new int[366];
        return CalCostInternal(days, costs, 0);        
    }
    
    private int CalCostInternal(int[] days, int[] costs, int index)
    {
        if(index >= days.Length) return 0;
        if(cost[days[index]] != 0) return cost[days[index]]; 
        
        var aCost = costs[0] + CalCostInternal(days, costs, index+1);
        
        var tmp = index;
        while(tmp < days.Length && days[tmp] - days[index] + 1 <= 7) tmp++;        
        var bCost = costs[1] + CalCostInternal(days, costs, tmp);
        
        tmp = index;
        while(tmp < days.Length && days[tmp] - days[index] + 1 <= 30) tmp++;        
        var cCost = costs[2] + CalCostInternal(days, costs, tmp);
        
        var min = aCost > bCost
            ? (bCost > cCost ? cCost : bCost)
            : (aCost > cCost ? cCost : aCost);        
        cost[days[index]] = min;
        return min;
    }
}
