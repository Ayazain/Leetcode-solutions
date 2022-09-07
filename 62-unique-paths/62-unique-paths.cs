public class Solution {
  public   int UniquePaths(int m, int n) {
   int [][]dp = new int[m][]; 
     for (int i = 0; i < m; i++)
     {
        dp[i]= new int[n];
     }
     dp[m-1][n-1]= 1 ; 
      for(int row = 0; row < m; row++)
        {
            dp[row][n-1] = 1;
        }
        
        for (int col = 0; col < n; col++)
        {
            dp[m-1][col] = 1;
        }
     for (int i = m-2 ; i >=0 ; i--)
     {
        for (int j = n-2; j >=0; j--)
        {
            dp[i][j] +=  dp[i+1][j]+dp[i][j+1];
           
        }
     }
     
        return  dp[0][0] ;  
}
}