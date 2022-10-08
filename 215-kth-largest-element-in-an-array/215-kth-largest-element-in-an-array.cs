public class Solution {
    public  int FindKthLargest(int[] nums, int k) {
        
         if (k==1) return nums.Max(); ; 
     PriorityQueue<int , int > myqueue = new PriorityQueue<int, int>(nums.Length+1 ) ;
     for(int i = 0 ; i < nums.Length ; i++)
     {
        myqueue.Enqueue(nums[i] , 1 -nums[i]);
     }          
     while(k>1)
     {
       myqueue.Dequeue();
       k--; 
     }
     return  myqueue.Peek();
    }
}