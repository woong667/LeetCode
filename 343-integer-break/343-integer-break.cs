public class Solution {
    public int IntegerBreak(int n) {
         int left;
            int right;
            int result;
            int maxResult;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            
            dic[2] = 1;
            dic[3] = 2;

            for(int i=4;i<=58;i++)
            {
                result = 1;
                maxResult = -1;
                left = 2;
                right = i-2;
                while(left<=right)
                {
                    if(left>dic[left])
                    {
                        result *= left;
                    }
                    else
                    {
                        result *= dic[left];
                    }

                    if(right>dic[right])
                    {
                        result *= right;
                    }
                    else
                    {
                        result *= dic[right];
                    }

                    if(maxResult<result)
                    {
                        maxResult = result;
                    }

                    result = 1;
                    left++;
                    right--;
                }
                dic[i] = maxResult;


            }
            
            return dic[n];
    }
}