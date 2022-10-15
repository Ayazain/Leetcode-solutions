public class Solution {
 public  int Trap(int[] height) {
        int []PrevMax = new int [height.Length]; int prev = 0  ;  int next = 0  ; 
         int []NextMax = new int [height.Length];
         int res = 0 ; 
         for (int i = 0  ; i < height.Length ; i++)
         {
          if (height[i]> prev ) { prev = height[i] ;} PrevMax[i] = prev; 
          if (height[height.Length-i-1]> next ) { next = height[height.Length-1-i] ;} NextMax[height.Length-i-1] = next; 
         }
         for (int i = 1 ; i < height.Length-1 ; i++)
         {
          if (height[i] < PrevMax[i-1] && height[i]<NextMax[i])
          {
             int min = Math.Min(PrevMax[i-1] , NextMax[i+1]); 
              res += min -height[i];
          }
         }
         return res  ; 
    }

}