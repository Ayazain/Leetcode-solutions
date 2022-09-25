public class Solution {
   public void SetZeroes(int[][] matrix)
    {
        Dictionary<int, bool> ZeroRows = new Dictionary<int, bool>();
        Dictionary<int, bool> ZeroCol = new Dictionary<int, bool>();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    if (!ZeroRows.ContainsKey(i)) ZeroRows.Add(i, true);
                    if (!ZeroCol.ContainsKey(j)) ZeroCol.Add(j, true);
                }
            }
        }
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (ZeroRows.ContainsKey(i) || ZeroCol.ContainsKey(j)) matrix[i][j] = 0;
            }
        }
    }
}