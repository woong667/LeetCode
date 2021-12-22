public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> list = new List<int>();
            IList<int> result = new List<int>();

            list.Add(1);
            int gap = 2;
            int midCnt = 1;
            if(rowIndex==0)
            {
                result.Add(1);
                return result;
            }
            
            
            for(int i=0;i<rowIndex;i++)
            {
                list.Add(1);
                if(i==rowIndex-1)
                {
                    result.Add(1);
                }
                if(list.Count-gap>0)
                {
                    for (int j =0;j<midCnt;j++)
                    {
                        int listCnt = list.Count;
                        list.Add(list[listCnt - gap] + list[listCnt - gap + 1]);
                        if(i==rowIndex-1)
                        {
                            result.Add(list[listCnt - gap] + list[listCnt - gap + 1]);
                        }
                    }
                    midCnt++;
                }
                list.Add(1);
                if(rowIndex-1==i)
                {
                    result.Add(1);
                }
                gap++;
            }

            return result;
    }
}