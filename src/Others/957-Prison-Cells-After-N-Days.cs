public class Solution {
    public int[] PrisonAfterNDays(int[] cells, int N) {            
        
        byte cell = (byte)((cells[0] << 7) + (cells[1] << 6) + (cells[2] << 5) + (cells[3] << 4)
                               + (cells[4] << 3) + (cells[5] << 2) + (cells[6] << 1) + cells[7]);

        var state = new Dictionary<int, byte>();
        int i; 
        for (i = 0; i < N; i++)
        {
            cell = (byte)((~(cell ^ (cell << 2)) >> 1) & 0b_0111_1110);

            if (state.ContainsValue(cell)) break;

            state[i] = cell;
        }

        if (i < N)
        {
            cell = state[(N-1) % state.Count];
        }

        var rst = new int[8];
        rst[0] = (cell & 0b_1000_0000) >> 7;
        rst[1] = (cell & 0b_0100_0000) >> 6;
        rst[2] = (cell & 0b_0010_0000) >> 5;
        rst[3] = (cell & 0b_0001_0000) >> 4;
        rst[4] = (cell & 0b_0000_1000) >> 3;
        rst[5] = (cell & 0b_0000_0100) >> 2;
        rst[6] = (cell & 0b_0000_0010) >> 1;
        rst[7] = (cell & 0b_0000_0001);

        return rst;
    }
}
