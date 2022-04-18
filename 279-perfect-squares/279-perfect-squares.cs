public class Solution {
    public int NumSquares(int n) {
            int min= Int32.MaxValue;
            int[] dp = new int[10001];
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 3;
            for(int i=4;i<n+1;i++)
            {
                if((Math.Sqrt(i))%1==0)  //제곱근이면
                {
                    dp[i] = 1;
                }
                else //제곱근이 아닌애들
                {
                    int left = 1;
                    int right = i - 1;
                    while(left<=right)
                    {
                        min = min < (dp[left] + dp[right]) ? min : dp[left] + dp[right];
                        left++;
                        right--;
                    }
                    dp[i] = min;
                    min = Int32.MaxValue;
                }
            }
            return dp[n];
    }
}