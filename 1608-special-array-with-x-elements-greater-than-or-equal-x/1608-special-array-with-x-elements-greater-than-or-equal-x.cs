public class Solution {
    public int SpecialArray(int[] nums) {
           //nums에 있는 숫자는 아니면서 nums에 있는 숫자들보다 작은 최대의 양수를 구하는 문제
            int result = -1;
            int numsLen = nums.Length;
            List<int> list = new List<int>();
            for(int i=0;i<numsLen;i++)
            {
                list.Add(nums[i]);
            }
            list.Sort();
            int listMax = list[numsLen - 1];
            for(int i=1;i<=listMax;i++)
            {
                int tmpCount = 0;
                for(int j=0;j<numsLen;j++)
                {
                    if(i<=list[j])
                    {
                        tmpCount++;
                    }
                }
                if(tmpCount==i)
                {
                    result = i;
                }
            }
            return result;
    }
}