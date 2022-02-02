public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        bool result = false;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = 1;
                }
                else
                {
                    return true;
                }
            }
            
            return result;
    }
}