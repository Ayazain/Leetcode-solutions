public class Solution {
    public int[][] Merge(int[][] intervals) {
     if (intervals == null || intervals.Length == 0) return new List<int []>().ToArray();
        Array.Sort(intervals ,(a,b)=>a[0].CompareTo(b[0]) );
         List<int[]> MergedInterval  =   new List<int[]>() ; 
         
            int index = 0  ; 
         for (int i = 0  ; i < intervals.Length ;i++) 
         { 
          if(i == 0 ) {MergedInterval.Add(intervals[i]); index++; continue ; }
          if( MergedInterval[index-1][1]>= intervals[i][0])
             MergedInterval[index-1][1] = Math.Max(MergedInterval[index-1][1], intervals[i][1]);
         else 
         {
             MergedInterval.Add(intervals[i]); index++;}
         }
         return MergedInterval.ToArray();
    
    }
}