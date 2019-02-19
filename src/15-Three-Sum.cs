        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums.Length < 3)
            {
                return new List<IList<int>>();
            }

            int len = nums.Length, i = 0;
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);

            while (i < len - 2)
            {
                if ((i == 0) || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int sum = 0 - nums[i];
                    int lo = i + 1, hi = len - 1;
                    while (lo < hi)
                    {
                        if (nums[lo] + nums[hi] == sum)
                        {
                            if ((hi == len - 1) ||
                                (nums[lo] != nums[lo - 1] || nums[hi] != nums[hi + 1]))
                            {
                                result.Add(new List<int>() { nums[i], nums[lo], nums[hi] });
                            }
                            lo++; hi--;
                        }
                        else if (nums[lo] + nums[hi] < sum)
                        {
                            lo++;
                        }
                        else
                        {
                            hi--;
                        }
                    }
                }

                i++;
            }
            return result;
        }