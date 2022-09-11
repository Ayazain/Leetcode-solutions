public class Solution {
    public int[][] Merge(int[][] intervals) {
  if (intervals == null || intervals.Length == 0) return new List<int []>().ToArray();
        Array.Sort(intervals ,(a,b)=>a[0].CompareTo(b[0]) );
         List<int[]> MergedInterval  =   new List<int[]>() ; 
         for (int i = 0  ; i < intervals.Length ;i++) 
         {
            int index = 0  ;  
          while (index < MergedInterval.Count &&MergedInterval[index][1]< intervals[i][0]) index++;
          if (index >=MergedInterval.Count ) 
          MergedInterval.Add(intervals[i]);
          else 
          MergedInterval[index][1] = Math.Max(MergedInterval[index][1], intervals[i][1]);
         }
         return MergedInterval.ToArray();       
    }
}