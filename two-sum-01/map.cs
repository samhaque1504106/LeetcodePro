using System;
using System.Collections.Generic;
public class map
{
    public int[] TwoSum(int[] nums, int target)
    {
        int n = nums.Length;
        int[] res;
        
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int complement = target - nums[i];
            if (seen.ContainsKey(complement))
            {
                res = new int[] { seen[complement], i };
                return res;
            }

            seen[nums[i]] = i;
        }
        res= new int[]{-1,-1};
        return res;
    }
}