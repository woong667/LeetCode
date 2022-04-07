public class Solution {
    public int ThreeSumMulti(int[] arr, int target) {
            int result = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(dic.ContainsKey(target-arr[i]-arr[j]))
                    {
                        result += dic[target - arr[i] - arr[j]];
                    }
                }
                result = result % 1000000007;
                if (!dic.ContainsKey(arr[i]))
                {
                    dic.Add(arr[i], 1);
                }
                else
                {
                    dic[arr[i]] += 1;
                }
            }

            return result % 1000000007;
    }
}