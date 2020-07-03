// Runtime: 108 ms
// Memory Usage: 22.1 MB

        public static int FirstMissingPositive(int[] nums)
        {
            int len = nums.Length;
            int rst = -1, i = 0;

            if (len == 0) rst = 1;
            if (len == 1) rst = (nums[0] == 1) ? 2 : 1;
            if (len > 1)
            {
                for (i = 0; i < len; i++)
                {
                    while (nums[i] > 0 && nums[i] < len && nums[nums[i] - 1] != nums[i])
                    {
                        int tmp = nums[nums[i] - 1];
                        nums[nums[i] - 1] = nums[i];
                        nums[i] = tmp;
                    }
                }

                for (i = 0; i < len; i++)
                {
                    if (nums[i] != (i + 1))
                    {
                        rst = i + 1;
                        break;
                    }
                }
                if (i == len) rst = i + 1;
            }

            return rst;
        }