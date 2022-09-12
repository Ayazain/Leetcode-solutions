public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
      
        Dictionary<int ,List<int> > mynums  = new Dictionary<int, List<int>>();
        List<int> ret = new List<int>();
        for(int i = 0 ; i < nums.Length ;i++)
        {
            if(!mynums.ContainsKey(nums[i]))
                mynums.Add(nums[i], new List<int>());
             mynums[nums[i]].Add(i);   
        }
        for(int i = 0 ;i < nums.Length ; i++ )
        {
            int val = target-nums[i];
            if (mynums.ContainsKey(val))
            {
                ret.Add(i);
                if (mynums[val][0]== i && mynums[val].Count > 1 ) 
                     ret.Add(mynums[val][1]);
                else if(mynums[val][0]!= i)
                      ret.Add(mynums[val][0]);
              else {ret.Remove(i); continue ;} 
         
                break;
            }
        }
        return ret.ToArray();
    }
}