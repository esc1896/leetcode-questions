public class Solution {
    public int OrangesRotting(int[][] grid) {
        
        var min = 0;
        var hasFresh = false;
        var changed = true;
        while (changed)
        {
            changed = false;
            var changedSet = new HashSet<(int,int)>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if ((i > 0 && grid[i - 1][j] == 2)
                            || (i < grid.Length - 1 && grid[i + 1][j] == 2)
                            || (j > 0 && grid[i][j - 1] == 2)
                            || (j < grid[i].Length - 1 && grid[i][j + 1] == 2))
                        {
                            changed = true;
                            changedSet.Add((i, j));
                        }

                        hasFresh = !changed;
                    }
                }
            }

            foreach (var point in changedSet)
            {
                grid[point.Item1][point.Item2] = 2;
            }

            if (hasFresh && !changed) return -1;
            if (changed) min++;
        }
        return min;
    }
}
