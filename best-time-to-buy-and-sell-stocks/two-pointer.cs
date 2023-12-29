public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int left=0, right = 0, mp=0, cp=0;
         
        while(right<prices.Length)
        {
            // calculate current  profit
            cp = prices[right] - prices[left];
             
            //  cprofit > 0, shift lp = rp
            if(cp<0)
            {
                left = right;
            }
            //if cp > mp, update maxprofit
            if(mp<cp)
            {
                mp = cp;
            }

            right++;

        }

        return mp;
    }
    
}