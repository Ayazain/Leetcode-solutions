public class Solution {
         public   Dictionary<int, int> lookup;

    public   int[] TopKFrequent(int[] nums, int k)
    {
        lookup = new Dictionary<int, int>();
        int []res = new int[k];
        for (int i = 0; i < nums.Length; i++)
        {
            if (!lookup.ContainsKey(nums[i])) lookup.Add(nums[i], 1);
            else lookup[nums[i]]++;
        }
        KeyValuePair<int , int >[] arr = new KeyValuePair<int ,int >[lookup.Count] ;
        int index =0 ;  
        foreach( KeyValuePair<int , int > x in lookup)
        {
          arr[index] = x; index++;
        }
        Array.Sort(arr , (a,b)=>b.Value.CompareTo(a.Value));
        index =0; ;
        while(index < k )
        {
          res[index] = arr[index].Key ; 
         index++;
        }

return res ; 
    }


}