public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
         int[] result = new int[nums.Length - k + 1];
            List<int> list = new List<int>();
            for(int i=0;i<k;i++)
            {
                list.Add(nums[i]);
            }
            list.Sort();
            result[0] = list[k - 1];
            for(int i=1;i<nums.Length-k+1;i++)
            {
                int bfNum = nums[i-1];
                int nowNum = nums[i + k - 1];
                list.Remove(bfNum);
                int nowIndex = list.BinarySearch(nowNum);
                if (nowIndex < 0)
                {
                    list.Insert(~nowIndex, nowNum);
                }
                else
                {
                    list.Insert(nowIndex, nowNum);
                }
               // list.Add(nowNum);
                //list.Sort();
                result[i] = list[k - 1];
            
            }
            return result;
    }
}