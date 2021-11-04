class Solution {
public:
    vector<int> nextGreaterElement(vector<int>& nums1, vector<int>& nums2) {
        vector <int> result;
        int num1Element;
        int num2Element;
        int nums2Index;
        for(int i=0;i<nums1.size();i++)
        {
            num1Element=nums1[i];
            nums2Index=findIndex(nums2,num1Element);
            for(int j=nums2Index;j<nums2.size()+1;j++)
            {
                if(j==nums2.size())
                {
                    result.push_back(-1);
                    break;
                }
                
                if(num1Element<nums2[j])
                {
                    result.push_back(nums2[j]);
                    break;
                }
            }
            
        }
        
        return result;
    }
    
    
    int findIndex(const vector<int> &arr, int item) {
    auto ret = find(arr.begin(), arr.end(), item);

    if (ret != arr.end())
        return ret - arr.begin();
    return -1;
}
};