public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
     
        List<int[]> ret = new List<int[]>(); int index = 0;
        if (intervals == null || intervals.Length == 0)
        {
            ret = new List<int[]>();
            ret.Add(newInterval);
            return ret.ToArray();
        }
        bool yes = true;
        for (int i = 0; i < intervals.GetLength(0); i++)
        {
            if (!yes) { ret.Add(intervals[i]); index++; continue; }

            if (intervals[i][1] >= newInterval[0])
            {
                yes = false; 
                if (intervals[i][0] <=newInterval[1])// Merge 
                {
                    ret.Add(new int[] { Math.Min(intervals[i][0], newInterval[0]), Math.Max(intervals[i][1], newInterval[1]) });
                    index++;
                    while (i < intervals.Count() - 1 && ret[index - 1][1] >= intervals[i + 1][0])
                    {
                        ret[index - 1][1] = Math.Max(ret[index - 1][1], intervals[i + 1][1]);
                        i++;
                    }
                    index++;
                }
                else // Add before 
                {
                    ret.Add(newInterval);
                    ret.Add(intervals[i]);
                    index += 2;
                  
                }
            }
            else { ret.Add(intervals[i]); index++; }
        }
    
         if(yes) ret.Add(newInterval); 
        return ret.ToArray();  
    }
}