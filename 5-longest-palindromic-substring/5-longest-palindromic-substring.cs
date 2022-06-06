
public class Solution {
    public string LongestPalindrome(string s) {
         int i = 0 , max =0 , index = 0  , res =0;
        while (i < s.Length  )
        {
            
              res  =   Check(s , i , i+1 ) ;   
           
          int  res2  =   Check(s , i-1 , i+1 )+1 ;
              res = Math.Max(res , res2);
        if  (res > max )
        { 
            index = i ; max = res ;
        }
          i++;  
        }
        
        if(max%2 != 0)
        return s.Substring(index-(max/2), max) ; 
        else 
        return s.Substring(Math.Max(index-(max/2)+1 , 0 ), max) ; 
    }
    public int  Check(string arr  , int s , int e  )
    {  
        if (s < 0 || e >= arr.Length )
        return 0 ;
        if (arr[s] == arr[e]) 
           return   Check(arr , s-1 , e+1)  + 2 ;
        else 
           return  0 ;  
            
    }
    
}