public class Solution {
 public  int Rob(int[] nums) {
   if (nums.Length <= 3 ) return nums.Max();
     Dictionary<int , int >lookup= new Dictionary<int, int>();    
      int m1 =    RopHelpper2(nums , 0 );
       int m2 =   RopHelpper2(nums , 1 );
        return Math.Max(m1,m2);
     }

public  int  RopHelpper2(int []nums  , int StartIndex  )
{
int [] max = new  int [nums.Length]; int maxval = 0 ;
for (int i = nums.Length-2+StartIndex  ; i >=StartIndex; i--)
{
   int mymax =0 ;  
 if (i+2 < nums.Length-1+StartIndex ) mymax= Math.Max(mymax , max[i+2]); 
  if (i+3 < nums.Length-1+StartIndex ) mymax= Math.Max(mymax , max[i+3]);  
  mymax += nums[i] ; 
  max[i] = mymax ; 
}
return Math.Max(max[StartIndex] , max[StartIndex+1]);
}
}