public class Solution {
    public int[] SmallestRange(IList<IList<int>> nums) {
           PriorityQueue<KeyValuePair<int , int> , int > myqueue = new PriorityQueue<KeyValuePair<int, int>, int>(nums.Count); 
        int max  = int.MinValue ;   int min = int.MaxValue; KeyValuePair<int , int >MinIndex ;  KeyValuePair<int , int >MaxIndex ; 
        for (int i = 0 ; i < nums.Count ; i++)
         { 
            if(nums[i] !=null && nums[i].Count>0)
              {
                 myqueue.Enqueue(new KeyValuePair<int, int>(i , 0),nums[i][0] );
                 if (nums[i][0] > max) { max  = nums[i][0] ; MaxIndex = new KeyValuePair<int, int>(i,0);}
              } 
        }
        int finalMin = 0  , finalMAx =0 ;  int interval = int.MaxValue ; 
        while(myqueue.Count == nums.Count  )
        {
          KeyValuePair<int , int > newindex  = myqueue.Dequeue(); // this s min 
           min  =  nums[newindex.Key][newindex.Value];
          if (max-min < interval){finalMAx = max ; finalMin= min ; interval = finalMAx-finalMin;}
    
        if (newindex.Value+1 >= nums[newindex.Key].Count) break;
         
         int  newelemnt = nums[newindex.Key][newindex.Value+1];
         
         if (max < newelemnt) {max = newelemnt ; MaxIndex = newindex;} 
          myqueue.Enqueue(new KeyValuePair<int, int>(newindex.Key , newindex.Value+1) , newelemnt) ; 
        }
        int[] arr = new int []{finalMin , finalMAx};
        return arr ; 
    }
}