public class Solution {
public   int FindPeakElement(int[] nums) {
       if (nums.Length == 1 ) return  0 ;
        int res = FindPeakElementHelpper(nums ,0 , nums.Length-1 );
         return res ; 
    }

    private  int FindPeakElementHelpper(int[] nums, int s, int e)
    {
      if (s>e) return -1 ;
      int mid = s+((e-s)/2); 
      bool right = false ;  bool left = false ; 
      if (mid-1 < 0  || nums[mid-1]< nums[mid] )  right= true ;
      if ( mid+1 > nums.Length -1||  nums[mid+1]< nums[mid] ) left = true ; 
        if (left & right) return  mid ; 
        if  (right)  
          return  FindPeakElementHelpper(nums ,mid+1 ,e  ); 
     
          return  FindPeakElementHelpper(nums ,s ,mid-1  ); 

    }
}