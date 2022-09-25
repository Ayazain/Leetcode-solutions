public class Solution {
   public void Rotate(int[][] arr) {
   
    int n = arr.Length;
    for (int i = 0  ; i < n/2 ; i++)
     {
      for (int j =i ; j < n-i-1 ; j++ )
      {
         int temp  = arr[i][j];
         arr[i][j] = arr[n-j-1][i]; 
          arr[n-j-1][ i ] = arr[n-i-1 ][n-j-1] ; 
           arr[n-i-1 ][n-j-1] =  arr[j][ n-i-1] ; 
           arr[j][ n-i-1]= temp ; 
      }

     }
    }
}