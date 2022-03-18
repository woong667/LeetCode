public class Solution {
    public int Calculate(string s) {
        int result = 0;
            Stack<string> stack = new Stack<string>();
            string temp = "";
            s = s.Replace(" ", "");
            for(int i=0;i<s.Length;i++)
            {
                

                if(s[i]!=')')
                {
                    if(s[i]=='('|| s[i] == '+' || s[i] == '-')
                    {
                        if(!string.IsNullOrEmpty(temp))
                        {
                            stack.Push(temp);
                            temp = "";
                        }
                        stack.Push(s[i].ToString());
                    }
                    else
                    {
                        temp += s[i];
                    }
                   
                   
                }
                else // s[i]==')'
                {
                    if (!string.IsNullOrEmpty(temp))
                    {
                        stack.Push(temp);
                        temp = "";
                    }
                    CntStack(ref stack);
                }
            }
            if(!string.IsNullOrEmpty(temp))
            {
                stack.Push(temp);
            }

            if(stack.Count!=0)  //마지막 스택에 남아있는 것들을 다 합해서 답을 구함.
            {
                result = MakeResult(ref stack);
            }
            return result;
    }
     public static void CntStack(ref Stack<string> stack)
        {
            int subResult = 0;
            while(stack.Peek()!="(")
            {
                string stackHead = stack.Peek();
                int nowInteger;
                if(stackHead!="+"&&stackHead!="-")
                {
                    nowInteger = Int32.Parse(stackHead); //맨 위의값을 읽어서 데이터에 넣고
                    stack.Pop();
                    if(stack.Peek()=="-")
                    {
                        nowInteger = -nowInteger;
                    }
                    else if(stack.Peek()=="(")
                    {
                        subResult += nowInteger;
                        stack.Pop();
                        stack.Push(subResult.ToString());
                        
                        break;
                    }
                    subResult += nowInteger;
                    stack.Pop();
                }
            }
            if (stack.Peek() == "(")
            {
                stack.Pop();
                stack.Push(subResult.ToString());
               
            }

            return;
        }

        public static int MakeResult(ref Stack<string> stack)
        {
            int result = 0;
            List<string> list = new List<string>();
            List<int> realList = new List<int>();
            bool isMinus = false;
            while(stack.Count!=0)
            {
                string head = stack.Peek();
                list.Add(head);
                stack.Pop();
            }
            list.Reverse();
            for(int i=0;i<list.Count;i++)
            {
                if(list[i]=="-")
                {
                    isMinus = true;
                }
                else if(list[i]=="+")
                {

                }
                else
                {
                    if(isMinus)
                    {
                        realList.Add(-Int32.Parse(list[i]));
                        isMinus = false;
                    }
                    else
                    {
                        realList.Add(Int32.Parse(list[i]));
                    }
                }
            }

            for(int i=0;i<realList.Count;i++)
            {
                result += realList[i];
            }

            return result;
        }
}