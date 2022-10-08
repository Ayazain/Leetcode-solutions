public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
          PriorityQueue<int , int > myqueue = new PriorityQueue<int, int>((int)matrix.LongLength ) ;
     for(int i = 0 ; i < matrix.Length ; i++)
     {
        for(int j = 0  ; j < matrix[i].Length ; j++)
             myqueue.Enqueue(matrix[i][j] , matrix[i][j]);
     }          
     while(k>1)
     {
       myqueue.Dequeue();
       k--; 
     }
     return myqueue.Dequeue();
    
    }
}