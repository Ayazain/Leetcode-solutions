public class Solution {
    public int SearchInsert(int[] nums, int target) {
         return  Searchindortedarray(nums , target , 0 , nums.Length-1);
    }
     public int Searchindortedarray(int[] nums, int target , int s , int e ) 
    {
        Console.WriteLine ( "start = " +s+ "end = " + e);
        if (e-s ==1   || s==e ) 
        {
            if(target <= nums[s]  )
        return s ; 
            else if(target > nums[ nums.Length-1]  )

                return e +1; 
            else 
                return e ; 
            
        } 
     int mid  =( (e-s) / 2  ) + s;
         Console.WriteLine ( mid);
        if(target == nums[mid])
            return mid ; 
        else  if (target < nums[mid] )
          return    Searchindortedarray(nums,  target ,  s ,mid);
         else 
           return   Searchindortedarray(nums,  target ,mid  , e );
    }
}