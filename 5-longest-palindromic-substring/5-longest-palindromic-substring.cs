public class Solution {
    public string LongestPalindrome(string s) {
       char beforeChar;
            char nextChar;
            int beforeIndex;
            int minBefore=0;
            int maxNext=0;
            int maxL = 1;
            int nowL=1;
            int nextIndex;
            string result = "";
            char now;
            char now2;


            //홀수 일때
            for(int i=0;i<s.Length;i++)
            {
                now = s[i];
                //interverl 을 1부터 주고 양쪽으로 비교.
                for(int j=1; ;j++)
                {
                    //string의 범위를 넘어버리면 break;
                    if (i - j < 0 || i + j > s.Length - 1)
                        break;

                    beforeChar = s[i - j];
                    nextChar = s[i + j];
                    if(beforeChar!=nextChar)
                    {
                        break;
                    }
                    nowL += 2;
                    if(nowL>maxL)
                    {
                        minBefore = i - j;  //여기서 일단 최대일때 뒷인덱스
                        maxNext = i + j;    //앞 인덱스 구해짐.
                        maxL = nowL;
                    }
                }
                nowL = 1;
            }



            //짝수일때
            nowL = 2;
            for(int i=0;i<s.Length;i++)
            {
                if (i + 1 > s.Length-1) 
                    break;

                now = s[i];
                now2 = s[i + 1];


                if (now != now2)
                    continue;


                beforeIndex = i;
                nextIndex = i + 1;
                //이 타이밍에 벌써 홀수보다 짝수가 커버리면
                if(nowL>maxL)
                {
                    minBefore = i;
                    maxNext = i + 1;
                }

                for(int j=1; ;j++)
                {
                    if (i - j < 0 || (i + 1) + j > s.Length - 1) //범위를 넘으면
                        break;

                    //범위를 넘지 않으면.
                    beforeChar = s[i - j];
                    nextChar = s[i + 1 + j];


                    if(beforeChar!=nextChar)
                    {
                        break;
                    }

                    nowL += 2;

                    beforeIndex = i - j;
                    nextIndex = i + 1 + j;


                    if (nowL>maxL)
                    {
                        minBefore = beforeIndex;
                        maxNext = nextIndex;
                        maxL = nowL;
                    }
                }
                nowL = 2;
            }

            for(int j=minBefore;j<=maxNext;j++)
            {
                result += s[j];
            }
            return result;
        
    }
}