class Solution {
public:
    int maxProfit(int k, vector<int>& prices) {
        int n = prices.size();
			vector<int> buy(k+1,INT_MIN), sell(k+1,0);

			for(int i=0; i<n; i++){
				for(int j=1; j<=k; j++){
					buy[j] = max(buy[j], sell[j-1]-prices[i]);
					sell[j] = max(sell[j], buy[j]+prices[i]);
				}
			} 
			return sell[k];
    }
};