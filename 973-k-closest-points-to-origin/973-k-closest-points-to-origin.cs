public class Solution {
 public int[][] KClosest(int[][] points, int k)
    {
        PriorityQueue<int, double> myqueue = new PriorityQueue<int, double>(points.Length + 1);
        int[][] res = new int[k][];
        int index; 
        for (int i = 0; i < points.Length; i++)
        {
            myqueue.Enqueue(i, Math.Abs((points[i][0]*points[i][0]) +(points[i][1]*points[i][1])));
        }
        while (k > 0)
        {
            index = myqueue.Dequeue();
            res[res.Length-k] = points[index];
            k--; 
        }
        return res  ; 
    }
}