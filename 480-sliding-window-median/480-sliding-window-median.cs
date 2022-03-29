public class Solution {
    public double[] MedianSlidingWindow(int[] nums, int k) {
        double[] result = new double[nums.Length - k + 1]; ;
            List<int> list = new List<int>();
            for (int i = 0; i < k; i++)
            {
                list.Add(nums[i]);
            }
            list.Sort();
            result[0] = GetMidNum(list, k); 
            for (int i = k; i <= nums.Length - 1; i++)
            {
                int beforeNum = nums[i - k];
                int nowNum = nums[i];
                int idx = Binary(list, k, nowNum);
                list.Insert(idx, nowNum);
                list.Remove(beforeNum);

                result[i - k + 1] = GetMidNum(list, k);
            }

            return result;
    }
    public static int Binary(List<int> list, int k, int target)
        {
            int left = 0;
            int right = list.Count-1;

            while(true)
            {
                int mid = (left + right) / 2;
                if(target==list[mid])
                {
                    return mid;
                }
                else if(target<list[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }


                if (left > right)
                    return left;
            }
        }

        public static double GetMidNum(List<int> list,int k)
        {
            if(k%2==0) //짝수일때
            {
                int left = 0;
                int right = list.Count - 1;
                long beforeNum = list[(left + right) / 2];
                long nextNum = list[((left + right) / 2) + 1];
                //return (list[(left + right) / 2]+list[((left + right) / 2)+1])/2.00f;
                return (beforeNum + nextNum) / 2.0;
            }
            else
            {
                int left = 0;
                int right = list.Count - 1;
                return list[(left + right) / 2];
            }
        }
}