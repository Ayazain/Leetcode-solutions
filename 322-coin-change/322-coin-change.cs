public class Solution {
    public int CoinChange(int[] coins, int amount) {
     int usedNumberOfCoins ;
        Array.Sort(coins);
        int[][] arr = new int[coins.Length + 1][];
        for (int i = 0; i <= coins.Length; i++)
        {
            arr[i] = new int[amount + 1];
        }
        for (int j = 1; j <= amount; j++)
        {
            arr[0][j] = int.MaxValue;
        }
        for (int j = 1; j <= coins.Length; j++)
        {
            arr[j][0] = 0;
        }

        for (int i = 1; i <= coins.Length; i++)  
        {
            for (int j = 1; j <= amount; j++)
            {
                int val = j-coins[i-1]; // Rest of the amount 
                if(val < 0)   {arr[i][j] = arr[i-1][j];continue; }
              else if(val == 0 ){ arr[i][j] = 1;  }
              else  
                {
                 usedNumberOfCoins =  arr[i][val] ; // used number of coins for the rest of the mony 
                 if (usedNumberOfCoins ==int.MaxValue  )arr[i][j]  =arr[i-1][j];
                 else   arr[i][j] = Math.Min(usedNumberOfCoins+1 , arr[i-1][j]); 
                }
        
            }
        }

       return (arr[coins.Length][amount] == int.MaxValue)?-1:arr[coins.Length][amount];
    }
}