public class Solution {
         public   int Tribonacci(int n) {
            Dictionary<int , int > memo  = new Dictionary<int, int> () ; 
            int res = 0 ; 
        for (int i = 0 ; i <= n ; i++)
        {
        if (i == 0) memo.Add(0 , 0); 
        else if (i==1||i==2)  memo.Add(i , 1 ); 
        else 
        {
            memo.Add(i , memo[i-1]+memo[i-2]+ memo[i-3])  ;
        }
        }
        return memo[n];
    }

}