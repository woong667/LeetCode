public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        
            int cnt = 1;
            int[] comp = new int[nums.Length];
            comp[0] = cnt;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i+1])
                {
                    cnt++;
                    comp[i+1] = cnt;
                }
                else //작으면
                {
                    cnt = 1;
                    comp[i+1] = cnt;
                }
            }
            int result = comp.Max();
            return result;
    }
}