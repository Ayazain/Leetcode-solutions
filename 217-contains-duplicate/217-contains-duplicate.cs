using System.Collections.Generic;
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
		HashSet<int> D = new HashSet<int>();
		for(int i = 0 ; i < nums.Length; i++)
		{
			if(D.Contains(nums[i]))
				return true ; 
			else 
		D.Add(nums[i]);
		}
		
		
			
        return false ; 
    }
}