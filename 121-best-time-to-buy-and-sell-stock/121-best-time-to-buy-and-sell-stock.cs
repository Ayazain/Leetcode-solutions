using System;
public class Solution {
    public int MaxProfit(int[] prices) {
        int Max = 0  ;
        int p = 0 ; 
        for ( int i = 1  ; i < prices.Length ; i++ )
        {
            if(prices[i] < prices[p])
                p = i ; 
            else 
                Max = Math.Max( prices[i]- prices[p] , Max) ;
        }
        return Max;
        
    }
}