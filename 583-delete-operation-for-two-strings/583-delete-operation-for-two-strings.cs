public class Solution {
    public int MinDistance(string str1, string str2) {
         if (str1.Length == 0 ||str2.Length == 0) return Math.Max(str1.Length, str2.Length);
      List< List<int> > dp = new List< List<int> >(); 
      for (int i = 0 ; i < str1.Length ; i++)
      {
         dp.Add(new List<int >()); 
        for (int j = 0 ; j < str2.Length ; j++)
        {
          if (str1[i] == str2[j])
          {
            if (i <=0 || j <=0 )  dp[i].Add(1);
              else 
              {
                dp[i].Add(dp[i-1][j-1]+1);
              }
          }
          else 
          {
            dp[i].Add(0);
           if (i > 0 ) dp[i][j] = Math.Max(dp[i][j] , dp[i-1][j]); 
            if (j > 0 )dp[i][j] = Math.Max(dp[i][j] , dp[i][j-1]);
          }
          
        }
      }
      int ret =  dp[dp.Count-1][dp[0].Count-1]    ;   
      int val  = str1.Length+str2.Length-(2*ret);
      return val ;                 
    }
}