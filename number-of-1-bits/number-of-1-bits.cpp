class Solution {
public:
    int hammingWeight(uint32_t n) {
        
        int result=0;
        while(1)
        {
            
            if(n%2==1)
            {
                result+=1;
            }
            n=n/2;
           
            if(n==1||n==0)
            {
                break;
            }
            
        }
        return n==1?result+1:result;
    }

};