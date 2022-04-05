public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
       int result = 0;
            int minResult=0;
            int tempGap;
            int minGap=2001;
            for(int i=0;i<nums.Length-2;i++)
            {
                for(int j=i+1;j<nums.Length-1;j++)
                {
                    for(int k=j+1;k<nums.Length;k++)
                    {
                        result = nums[i] + nums[j] + nums[k];
                        tempGap = target - result;
                        tempGap = tempGap < 0 ? ~tempGap + 1 : tempGap;
                        if(minGap>tempGap)
                        {
                            minGap = tempGap;
                            minResult = result;
                        }
                    }
                }
            }
            return minResult;
    }
}