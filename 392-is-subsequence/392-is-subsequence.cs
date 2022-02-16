public class Solution {
    public bool IsSubsequence(string input, string target) {
          bool flag = false;
            int moveIndex = 0;
           
            if(input.Length==0&&target.Length==0)
            {
                return true;
            }
            else if(target.Length == 0)
            {
                return false;
            }
            else if(input.Length==0)
            {
                return true;
            }

            Queue<char> queue =new Queue<char>();
            for(int i=0;i<input.Length;i++)
            {
                queue.Enqueue(input[i]);
            }
            while (queue.Count != 0 && flag==false)
            {
                char tmpInputChar = queue.ElementAt<char>(0);
                for (int i = moveIndex; i < target.Length; i++)
                {
                    char tmpTargetChar = target[i];

                    if(tmpInputChar.Equals(tmpTargetChar))
                    {
                        queue.Dequeue();
                        moveIndex = i + 1;
                        if(moveIndex==target.Length)
                        {
                            flag = true;
                            break;
                        }
                        break;
                    }

                    if(i==target.Length-1)
                    {
                        flag = true;
                        break;
                    }
                }
            }

            if(queue.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
    }
}