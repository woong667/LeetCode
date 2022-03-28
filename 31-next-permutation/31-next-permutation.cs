public class Solution {
    public void NextPermutation(int[] nums) {
         int pre = -1;
            int startIdx = -1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int now = nums[i];
                if (now >= pre)
                {
                    pre = now;

                }
                else
                {
                    int targetIdx = FindMinIndex(i + 1,now,ref nums);
                    Swap(i, targetIdx, ref nums);
                    startIdx = i + 1;
                    break;
                }
            }

            if (startIdx != -1&&startIdx<nums.Length)
            {
                Rever(startIdx, ref nums);
            }
            else
            {
                Rever(0, ref nums);
            }
    }
     public static void Rever(int idx, ref int[] nums)
        {
            int lastIdx = nums.Length - 1;
            while (idx < lastIdx)
            {
                Swap(idx, lastIdx, ref nums);
                idx++; lastIdx--;
            }
        }
        public static void Swap(int i, int j, ref int[] nums)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public static int FindMinIndex(int idx,int target,ref int[] nums)
        {
            int now = 101;
            int result = 0;
            for (int i = idx; i < nums.Length; i++)
            {
                if (target < nums[i]&&now>nums[i])
                {
                    result = i;
                }
            }
            return result;
        }
}