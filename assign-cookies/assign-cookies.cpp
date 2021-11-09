class Solution {
public:
    int findContentChildren(vector<int>& g, vector<int>& s) {
        int result=0;
        int idx=0;
        sort(g.begin(),g.end());
        sort(s.begin(),s.end());
        
        if(s.size()==0)
            return 0;
       for(int i=0;i<g.size();i++)
        {
            int gf=g[i];
            for(int j=idx;j<s.size();j++)
            {
               if(gf<=s[j]) //쿠키사이즈가 더 크다면
               {
                   result++; //결과값올리고
                   idx=j+1;
                   break;
                   
               }
            }
        }
        return result;
    }
};