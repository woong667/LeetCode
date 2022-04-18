public class Solution {
    public bool IsMonotonic(int[] nums) {
        
            bool res = false;
            if (isDecrease(nums) ||isIncrease(nums))
                res = true;

            return res;
    }
    public static bool isIncrease(int[] nums)
        {
            bool res = true;
            for(int i=1;i<nums.Length;i++)
            {
                if(nums[i]<nums[i-1])
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
        public static bool isDecrease(int[] nums)
        {
            bool res = true;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
}