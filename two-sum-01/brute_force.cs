namespace DefaultNamespace;

public class brute_force
{
    func twoSum(nums []int, target int) []int {
        //brute force
        int n = nums.Length;
        
        //int[] res = new int[2] { -1, -1 };

        for (int i = 0; i < n-1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (nums[i] + nums[j]==target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] { -1, -1 };
    }
}