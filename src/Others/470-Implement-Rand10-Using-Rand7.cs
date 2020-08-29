/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        
        int first;
        while(true)
        {
            first = Rand7();
            if(first != 4) break;
        }
        if(first < 4)
        {
            while(true)
            {
                var ran = Rand7();
                if(ran > 5) continue;
                return ran;
            }            
        }
        else
        {
            while(true)
            {
                var ran = Rand7();
                if(ran > 5) continue;
                return ran + 5;
            }
        }                
    }
}
