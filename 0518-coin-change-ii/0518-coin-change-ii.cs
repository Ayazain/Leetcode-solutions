public class Solution {
    public  int Change(int amount, int[] coins) {

       int res =  ChangeHelpper(amount , coins, 0 , new Dictionary<int , Dictionary<int , int >>());
       return res ; 
    }
    public  int ChangeHelpper (int amount , int[]coins , int index ,  Dictionary<int , Dictionary<int , int >> lookup  )
    {
    if (lookup.ContainsKey(amount)){ 
        if (lookup[amount].ContainsKey(index)) return lookup[amount][index] ;
    }
        int coin = coins[index] ; 
     if (index == coins.Length-1) 
     {
     return (amount%coin == 0 )? 1:0;
     }
     int num = 0  ; 
     for (int i = 0 ; i <= amount  ; i+=coin)
      num +=  ChangeHelpper( amount-i ,coins , index+1 ,lookup) ; 

   if (lookup.ContainsKey(amount)) 
      { lookup[amount].Add(index , num);} 
     else
     {
        Dictionary<int ,int > m = new Dictionary<int, int>();
        m.Add(index , num);
         lookup.Add(amount , m);
     } 
    return num; 
    }
}