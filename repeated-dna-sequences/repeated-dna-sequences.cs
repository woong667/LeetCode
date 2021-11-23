public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        
            
         IList<string> list = new List<string>();
            if (s.Length < 10)
                return list;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string subString = s.Substring(0, 10);
            dic.Add(subString, 1);
            for (int i=1;i<s.Length-9;i++)
            {
                subString = s.Substring(i, 10);
                if (dic.ContainsKey(subString))
                {
                    dic[subString] += 1;
                }
                else
                {
                    dic.Add(subString, 1);
                }
            }

            foreach(KeyValuePair<string,int> each in dic)
            {
                if(each.Value>1)
                {
                    list.Add(each.Key);
                }
            }
            

            return list;
    }
}