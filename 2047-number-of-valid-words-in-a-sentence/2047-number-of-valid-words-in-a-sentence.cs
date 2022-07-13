public class Solution {
    public int CountValidWords(string sentence) {
            int result = 0;
            // Array로 나누었음. 여기서 공백은 그냥 skip 처리하면 됨.
            string[] stringArr = sentence.Split(' ');
            foreach (var inputString in stringArr.Select((value, index) => (value, index)))
            {
                if (string.IsNullOrEmpty(inputString.value)) continue;
                else if (isValidSentence(inputString.value)) result++;
            }
            

            return result;
    }
   public static bool isValidSentence(string input)
        {
            bool result = true;
            int inputLength = input.Length;
            int hypenCnt = 0;
            int puncCnt = 0;
            char hypen = '-';

            char[] punc = { '!', '.', ',' };
            char[] digit = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            // 숫자가 포함되면 안됨.
            

            for(int i=0;i< input.Length;i++)
            {
                //숫자가 포함되어 있을 때
                if (digit.Contains(input[i]))
                {
                    result = false;
                    break;
                }
                // '!' , '.' , ','이 2번 이상 사용 되었을때
                if (punc.Contains(input[i]))
                {
                    puncCnt++;
                    if (puncCnt > 1)
                    {
                        result = false;
                        break;
                    }
                }

                //하이픈이 2번 이상 사용되었을때
                if (input[i] == hypen)
                {
                    hypenCnt++;
                    if (hypenCnt > 1)
                    {
                        result = false;
                        break;
                    }
                }
              
                // 맨 첫 인덱스, 맨 마지막 인덱스 인데
                if (inputLength != 1)
                {

                    if (i == 0)  //문장의 맨처음
                    {
                        if (input[i] == hypen)
                        {
                            result = false; break;
                        }
                        else if (punc.Contains(input[i]))
                        {
                            result = false; break;
                        }
                    }
                    else if (i == inputLength-1)  //마지막
                    {
                        if (input[i] == hypen)
                        {
                            result = false; break;
                        }
                    }
                    else  //중간.
                    {
                        if(punc.Contains(input[i]))
                        {
                            result = false;
                            break;
                        }
                    }

                }
                else //한자리 수인데.
                {
                    if (input[i] == hypen)
                    {
                        result = false;
                        break;
                    }
                }

                if (input[i] == hypen)
                {
                    if(!alphabet.Contains(input[i-1])||!alphabet.Contains(input[i+1]))
                    {
                        result = false;break;
                    }
                }
            }
            return result;
        }
}