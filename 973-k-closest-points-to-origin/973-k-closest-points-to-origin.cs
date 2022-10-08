public class Solution {
     private double distance(int v1, int v2)
    {
        return Math.Abs((v1*v1) +(v2*v2));
    }

    public int[][] KClosest(int[][] points, int k)
    {
        PriorityQueue<int, double> myqueue = new PriorityQueue<int, double>(points.Length + 1);
        int[][] res = new int[k][];
        int index,  j = 0;
        for (int i = 0; i < points.Length; i++)
        {
            myqueue.Enqueue(i, distance(points[i][0], points[i][1]));
        }
        while (k > 0)
        {
            index = myqueue.Dequeue();
            res[j] = points[index];
            k--; j++;
        }
        return res  ; 
    }
}