public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] result = new int[nums.Length];

            //dictionary 채워넣기
            for(int i=0;i<nums.Length;i++)
            {
                if(dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic[nums[i]] = 1;
                }
            }
            //

            for(int i=0;i<nums.Length;i++)
            {
                int sum = 0;
                for(int j=0;j<nums[i];j++)
                {
                    if (dic.ContainsKey(j))
                    {
                        sum += dic[j];
                    }
                }
                result[i] = sum;
            }

            return result;
    }
}