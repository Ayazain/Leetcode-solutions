public class Solution {
    public int Rob(int[] nums) {
        List<int >max  = new List<int >() ; 
        if (nums.Length < 1) return 0 ;  
        else if (nums.Length ==1 ) return nums[0]; 
        else if (nums.Length ==2 ) return Math.Max(nums[0], nums[1]);
        else 
        {
            max.Add(nums[0]);
            max.Add(nums[1]); 
            max.Add(Math.Max( nums[0]+nums[2],nums[1]));
            Console.WriteLine(max[0]+"   "+  max[1] + "   "+ max [2] );
            for (int i = 3 ; i < nums.Length ; i++ )
            {
              int maxval = Math.Max( nums[i]+max[i-2] , nums[i]+ max[i-3]); 
              max.Add(maxval); 
                  Console.WriteLine(i +""+ max[i]);
            }
        }
        return Math.Max(max[nums.Length-1], max[nums.Length-2]);
    }
}