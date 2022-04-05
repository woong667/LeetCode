public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        
           int sum = 0;
            int result = 100000;
            int n = nums.Length-1;
            Array.Sort(nums, (x, y) => x.CompareTo(y));
            for(int i=0;i<nums.Length-2;i++)
            {
                int left = i + 1;
                int right = n;
                while(left<right)
                {
                    sum = nums[i] + nums[left] + nums[right];
                    if (sum == target)
                        return target;

                    if(Math.Abs(target-result)>Math.Abs(target-sum))
                    {
                        result = sum;
                    }

                    if (sum > target) right--;
                    else left++;


                }

            }
            return result;
    }
}