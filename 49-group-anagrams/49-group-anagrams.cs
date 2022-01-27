public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
         IList<IList<string>> list = new List<IList<string>>();
            Dictionary<string, List<string>> dic = new Dictionary<string,List<string>>();
            List<string> strsList = new List<string>();
            for(int i=0;i<strs.Length;i++)
            {
                strsList.Add(strs[i]);
            }

            strsList.Sort();

            for(int i=0;i<strsList.Count;i++)
            {
                string now = new string(strsList[i].ToCharArray().OrderBy(x=>x).ToArray());

                if(!dic.ContainsKey(now))  //key-value 없으면 list 만들어서 해당 key에 넣어줌
                {
                    var keyList = new List<string>();
                    dic.Add(now, keyList);
                }
                dic[now].Add(strsList[i]);
            }
            List<KeyValuePair<string, List<string>>> compareList = new List<KeyValuePair<string, List<string>>>(dic);
            compareList.Sort(new DicComparer());
            for(int i=0;i<compareList.Count;i++)
            {
                List<string> temp = new List<string>();
                for (int j=0;j<compareList[i].Value.Count;j++)
                {
                   
                    temp.Add(compareList[i].Value[j]);
                }
                list.Add(temp);
            }
            return list;
    }
    
    public class DicComparer : IComparer<KeyValuePair<string, List<string>>>
        {
            public int Compare(KeyValuePair<string, List<string>> x, KeyValuePair<string, List<string>> y)
            {
                int cmp = 0;

                cmp = x.Value.Count.CompareTo(y.Value.Count);

                return cmp;
            }
            public DicComparer()
            {

            }
        }
}