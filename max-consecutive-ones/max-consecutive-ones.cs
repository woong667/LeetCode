public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        
      int max = 0;
            int now = 0;
            bool flag = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]==1)
                {
                    if (flag == true) 
                    {
                        now++;
                        if (max < now)
                            max = now;
                       
                    }
                    else  //첫 1
                    {
                        now++;
                        if (max < now)
                            max = now;
                        flag = true;
                    }
                   
                }
                else
                {
                    flag = false;
                    now = 0;
                }
            }
            return max;
    }
}