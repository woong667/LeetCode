public class Solution {
    public bool WordPattern(string pattern, string s) {
         List<string> list = makeList(s);
            if (list.Count != pattern.Length)
                return false;
            bool result = true;
            Dictionary<string, char> dic = new Dictionary<string, char>();
            Dictionary<char, string> dic2 = new Dictionary<char, string>();
            for (int i = 0; i < list.Count; i++)
            {
                char p = pattern[i];
                //현재 패턴에 대해서 

                //둘 다 key-value 있을 떄
                if (dic.ContainsKey(list[i]) && dic2.ContainsKey(p))
                {
                    //그게 다르면
                    if (dic[list[i]]!=p||dic2[p]!=list[i])
                    {
                        result = false;
                        break;
                    }

                }
                else if(dic.ContainsKey(list[i]))   //string에 대한 키만 있을때
                {
                    if(dic[list[i]]!=p)
                    {
                        result = false;
                        break;
                    }
                }
                else if(dic2.ContainsKey(p))        //패턴에 대한 키만 있을때 
                {
                    if (dic2[p] != list[i])
                    {
                        result = false;
                        break;
                    }
                }
                else
                {
                    dic[list[i]] = p;
                    dic2[p] = list[i];
                }

            }

            return result;
    }
    
     public static List<string> makeList(string s)
        {
            List<string> list = new List<string>();
            string word = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    word += s[i];
                }
                else
                {
                    list.Add(word.Trim());
                    word = "";
                }

            }
            list.Add(word.Trim());
            return list;
        }
}