public class Solution {
    public bool ValidPalindrome(string s) {
        int critic = 0;
            bool left = true;
            bool right = true;
            int pointer1=0, pointer2=s.Length-1;
            int tmpPointer1, tmpPointer2;
            while(pointer1<=pointer2)
            {
                

                if(s[pointer1]!=s[pointer2]) //다르다면.
                {
                    critic++;
                    if (critic > 1)
                    {
                        return false;
                    }
                    tmpPointer1 = pointer1 + 1; //왼쪽을 먼저 1올려봄
                    tmpPointer2 = pointer2;
                    while(tmpPointer1 <= tmpPointer2)
                    {
                        if (s[tmpPointer1] != s[tmpPointer2]) //다르다면.
                        {
                            left = false;
                            break;
                        }
                        tmpPointer1++;
                        tmpPointer2--;
                    }


                    tmpPointer1 = pointer1; 
                    tmpPointer2 = pointer2-1;


                    while (tmpPointer1 <= tmpPointer2)
                    {
                        if (s[tmpPointer1] != s[tmpPointer2]) //다르다면.
                        {
                            right = false;
                            break;
                        }
                        tmpPointer1++;
                        tmpPointer2--;
                    }

                    if (!right && !left)
                    {
                        critic++;
                        break;
                    }
                    else
                        break;


                }
                pointer1++;
                pointer2--;
            }


            return critic < 2 ? true : false;
    }
}