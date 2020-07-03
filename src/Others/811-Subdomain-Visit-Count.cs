// 268 ms 83.54%
// 33 MB 65.42%
public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        
        var dict = new Dictionary<string,int>();
        for(int i = 0; i < cpdomains.Length; i++)
        {
            var list = cpdomains[i].Split(' ');
            var count = Int32.Parse(list[0]);
            dict[list[1]] = dict.ContainsKey(list[1])
                ? dict[list[1]]+count 
                : count;
            
            var domain = list[1].Split('.');
            dict[domain[domain.Length-1]] = dict.ContainsKey(domain[domain.Length-1])
                ? dict[domain[domain.Length-1]]+count 
                : count;
            
            if(domain.Length == 3)
            {
                var subDomain = domain[1]+"."+domain[2];
                dict[subDomain] = dict.ContainsKey(subDomain)
                    ? dict[subDomain] + count
                    : count;
            }                                                        
        }
        
        var rst = new List<string>();
        foreach(var ele in dict)
        {
            rst.Add($"{ele.Value} {ele.Key}");            
        }
        
        return rst;        
    }
}
