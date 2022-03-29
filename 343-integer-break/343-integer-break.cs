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
               
                    result = result * (left > dic[left] ? left : dic[left]);
                    result = result * (right > dic[right] ? right : dic[right]);
                    maxResult = maxResult < result ? result : maxResult;

                    result = 1;
                    left++;
                    right--;
                }
                dic[i] = maxResult;


            }
            
            return dic[n];
    }
}