public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        
            IList<int> temp = new List<int>();
            IList<IList<int>> list = new List<IList<int>>();
            recur(candidates, target, 0, 0, ref temp,ref list);
            
            return list;
    }
    
    public static void recur(int[] canditadate,int target,int sum,int idx, ref IList<int> temp,ref IList<IList<int>> result)
        {
            if (target == sum)  //target이랑 sum이랑 같으면
            {
                IList<int> subtemp = new List<int>();
                for(int i=0;i<temp.Count;i++)
                {
                    subtemp.Add(temp[i]);
                }
                result.Add(subtemp);
            }
            else if (sum < target) //target 보다 sum이 작으면.
            {
                for (int i = idx; i < canditadate.Length; i++) //다시 해당 위치부터 target에 맞는 합의 모임을 찾아감.
                {
                    temp.Add(canditadate[i]);
                    recur(canditadate, target, canditadate[i] + sum, i, ref temp,ref result);
                }

            }
            if (temp.Count > 0)
            {
                temp.RemoveAt(temp.Count - 1);
            }
                return;
            
        }
}