public class Solution {
    public int ClimbStairs(int n) {
        int[] arr = new int [n] ; 
        for (int i = 0 ; i < n ;i++)
        {
            if(i<3)
                arr[i] =i+1 ; 
            else 
                arr[i] = arr[i-1] + arr[i-2];
            
        }
        return arr[n-1] ;
        
    }
  
}