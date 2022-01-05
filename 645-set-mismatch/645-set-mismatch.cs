public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] result = new int[2];
            int remem = -1;
            bool[] chk = new bool[nums.Length+1];
            for(int i=0;i<nums.Length;i++)
            {
                if(chk[nums[i]]==true) //이미 있는애가 또 나온거임
                {
                    remem = i;
                    result[0] = nums[i];
                }
                chk[nums[i]] = true;
            }  //bool 체크 완료

            for(int i=1;i<chk.Length;i++)
            {
                if(chk[i]==false)
                {
                    result[1] = i;
                }
            }
            
           

            return result;
    }
}