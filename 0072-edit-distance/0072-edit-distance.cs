public class Solution {
  public  int MinDistance(string word1, string word2)
    {

        int[][] cash = new int[word1.Length + 1][];
        for (int i = 0; i < word1.Length+1; i++)
            cash[i] = new int[word2.Length+1];

      for (int i = word2.Length ; i>=0 ; i--)
          cash[word1.Length][i] = word2.Length-i;
          for (int i = word1.Length ; i>=0 ; i--)
          cash[i][word2.Length] = word1.Length-i;
          

          for (int i = word1.Length-1  ;i >=0 ; i-- )
             for (int j = word2.Length-1 ; j>=0 ; j--)
             {
                 if (word1[i]== word2[j]) cash[i][j]= cash[i+1][j+1] ; 
                 else cash[i][j]= 1+Math.Min( Math.Min(cash[i+1][j+1] , cash[i+1][j]), cash[i][j+1]);
             }
    
          return cash[0][0] ; 
    }
}