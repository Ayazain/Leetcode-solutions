public class Solution {
        public int FindTargetSumWays(int[] nums, int target)
    {
       List<int > sums = new List<int>();
       if (nums.Count() ==0) return 0;
        
       sums.Add(nums[0]);
        sums.Add(-1*nums[0]);
      
        return   DFS(nums, 1,  target, sums);
    }
    private int DFS(int[] nums, int index, int target, List<int> sums)
    {
        if (index == nums.Count())
        {
            int ret = 0;
            for (int i = 0; i < sums.Count; i++)
            { 
                if (sums[i] == target)
                    ret++;
             //   Console.WriteLine(sums[i] );
            }
            return ret;
        }
        else
        {
            List<int> copy = new List<int>(sums);
            for (int i = 0; i < sums.Count; i++)
            {
                copy[i] -= nums[index];
                sums[i] += nums[index];
            }
            sums.AddRange(copy);
            //Console.WriteLine(sums.Count);
            return DFS(nums, index + 1, target, sums);
        }
    }

}