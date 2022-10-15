public class Solution {
   public   int[] CountBits(int n)
  {
    Dictionary<int , int > lookup = new Dictionary<int, int>();
        int[] arr = new int [n+1]; 
        arr[0] = 0 ; 
        for (int i = 1 ; i <= n ; i++ )
        {
          if (i<=2)
             arr[i] =  CountBitsHelpper(i) ;
          else 
             {int d = i/2 ; int r = i%2  ;  arr[i] = arr[d]+arr[r];}   
        }
        return arr  ; 
  }

    private   int CountBitsHelpper(int num)
    {
       int count = 0 ; 
       while (num!=0)
       {
        num = num &(num-1);
        count++;
       }
    return count ; 
    }
}