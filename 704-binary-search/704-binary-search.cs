public class Solution {
    public int Search(int[] nums, int target) 
    {
     return  Searchindortedarray(nums , target , 0 , nums.Length-1);
    }
     
    public int Searchindortedarray(int[] nums, int target , int s , int e ) 
    {
        Console.WriteLine ( "start = " +s+ "end = " + e);
        if (s==e   ) 
        {
          if (  target == nums[s])
            return s;
            else 
                return -1 ; 
        } 
     int mid  =( (e-s) / 2  ) + s;
         Console.WriteLine ( mid);
        if(target == nums[mid])
            return mid ; 
        else  if (target < nums[mid] )
          return    Searchindortedarray(nums,  target ,  s ,Math.Max(mid-1  , 0));
         else 
           return   Searchindortedarray(nums,  target , Math.Min( mid+1 , nums.Length-1)  , e );
    }
}