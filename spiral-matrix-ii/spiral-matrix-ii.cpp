class Solution {
public:
    vector<vector<int>> generateMatrix(int n) {
        
        vector<vector<int>> check(n,vector<int>(n,0));
        vector<vector<int>> result(n,vector<int>(n,0));
        
        result[0][0]=1;
        check[0][0]=1;
        
        int now=0;
        int maxidx=n*n;
        int mx[4]={0,1,0,-1};
        int my[4]={1,0,-1,0};
        int locX=0;
        int locY=0;
        int ch=0;

        
        for(int idx=2;idx<=maxidx; )
        {
            
            now=ch%4;
            locX=locX+mx[now];
            locY=locY+my[now];
            if(locX==n||locY==n||locX<0||locY<0||check[locX][locY]==1)
            {
                locX=locX-mx[now];
                locY=locY-my[now];
                ch++;
                continue;
            }
            result[locX][locY]=idx;
            check[locX][locY]=1;
            idx++;
            
        }
       
       return result;
    }
};