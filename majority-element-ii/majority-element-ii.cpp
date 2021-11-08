class Solution {
public:
    vector<int> majorityElement(vector<int>& nums) {
        
        int n=nums.size()/3;
        unordered_map< int , int > m ;
        vector<int> result;
        for(int i=0;i<nums.size();i++)
        {
            m[nums[i]]=m[nums[i]]+=1;
        }
        
        for(auto v :m)
        {
            if(v.second>n)
                result.push_back(v.first);
        }

        return result;
    }
};