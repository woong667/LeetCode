public class Solution {
    public IList<string> CommonChars(string[] words) {
        IList<string> list = new List<string>();
            int cnt = words.Length;
            string[] alphabet = new string[26]{ "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            int[,] result = new int[cnt,26];
            for(int i=0;i<cnt;i++)
            {
                string now = words[i];
                for(int j=0;j<now.Length;j++)
                {
                    string nowChar = now[j].ToString();
                    for(int k=0;k<26;k++)
                    {
                        if(nowChar==alphabet[k])
                        {
                            result[i, k] += 1;
                        }
                    }
                }

            }
            for(int i=0;i<26;i++)
            {
                int minAlp = 100000000;
                for(int j=0;j<cnt;j++)
                {
                    if(result[j,i]<minAlp)
                    {
                        minAlp = result[j, i];
                    }
                }
                if(minAlp>0)
                {
                    for(int j=0;j<minAlp;j++)
                    {
                        list.Add(alphabet[i]);
                    }
                }
            }
            return list;
    }
}