/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    int rob(TreeNode* root) {
        
        vector<int> dp=getMax(root);
        
        if(dp[0]>dp[1])
            return dp[0];
        else
            return dp[1];
    
    }
    
    vector<int> getMax(TreeNode * target)
    {
        vector<int> dp={0,0};
        
        if(target==NULL)
            return dp;
        
        if(target->left==NULL&&target->right==NULL)
        { dp[0]=target->val; return dp;}
        //여기까지 내려온거면 좌우든 누가 있다는거
        
        vector<int> leftPrice=getMax(target->left);
        vector<int> rightPrice=getMax(target->right);
        
        int leftMax = (leftPrice[0] > leftPrice[1]) ? leftPrice[0] : leftPrice[1];
        int rightMax = (rightPrice[0] > rightPrice[1]) ? rightPrice[0] : rightPrice[1];
        
        dp[0]=leftPrice[1]+rightPrice[1]+target->val;
        dp[1]=leftMax+rightMax;
        
        return dp;
        
    }
};