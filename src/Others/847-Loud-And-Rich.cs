// Runtime: 408 ms
// Memory Usage:41 MB

public class Solution {
    public List<int>[] rich;
    public int[] answer;
    public int[] LoudAndRich(int[][] richer, int[] quiet)
    {
        int len = quiet.Length;
        if (len <= 1) return new int[] { 0 };

        answer = new int[len];
        for (int i = 0; i < len; i++)
            answer[i] = -1;

        rich = new List<int>[len];
        for (int i = 0; i < len; i++)
            rich[i] = new List<int>();

        for (int i = 0; i < richer.GetLength(0); i++)
            rich[richer[i][1]].Add(richer[i][0]);

        for (int i = 0; i < len; i++)
            dfs(quiet, i);

        return answer;
    }

    private int dfs(int[] quiet, int people)
    {                        
        if (answer[people] >= 0) return answer[people];

        // Console.WriteLine("calc people:{0}", people);

        answer[people] = people;
        for (int i = 0; i < rich[people].Count; i++)
            if (quiet[dfs(quiet, rich[people][i])] < quiet[answer[people]]) answer[people] = answer[rich[people][i]];

        return answer[people];
    }
}