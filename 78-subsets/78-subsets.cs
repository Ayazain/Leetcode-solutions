public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
          List<List<int>> res  = new List<List<int>>();
        
           GetallSubsets(nums, 0, new List<int>(), res);
        IList<IList<int>> kk = new List<IList<int>>(res);
        return kk;
    }
    
    public void GetallSubsets(int[] nums, int index, List<int> currSubset, List<List<int>> outpot)
        {
            if (index == nums.Length)
            {
                outpot.Add(currSubset);
                return ;
            }
            GetallSubsets(nums, index + 1, new List<int>(currSubset), outpot);
            currSubset.Add(nums[index]);
            GetallSubsets(nums, index + 1,new List<int>( currSubset), outpot);
            return ;
        }
}