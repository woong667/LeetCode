public class Solution {
    public int ClimbStairs(int n) {
            int[] list = new int[n+1];
            list[1] = 1;
            if (n > 1)
            {
                list[2] = 2;
            }
            for(int i=3;i<=n;i++)
            {
                list[i] = list[i - 2] + list[i - 1];
            }
            return list[n];
    }
}