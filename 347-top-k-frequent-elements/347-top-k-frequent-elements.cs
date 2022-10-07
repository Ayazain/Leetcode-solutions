public class Solution {
    class Heep
    {
        int sizeOfTree ;  
    
        KeyValuePair<int , int >[] HeepArr;  
        public Heep( int size )
        {
        HeepArr  = new KeyValuePair<int, int>[ size+ 1] ;   
        HeepArr[0] = new KeyValuePair<int, int>() ; 
        sizeOfTree = 1 ; 
        }
        public int peek()// eturn firest elemnt 
        { 
            if (sizeOfTree < 1 ) return -1 ; 
            else 
            return HeepArr[1].Value ;  
 
        }

        public void Insert(int val , int  num  )
        {
         HeepArr[sizeOfTree] = new KeyValuePair<int, int>(val , num);
         HepifybottomToUp( sizeOfTree); 
         sizeOfTree++ ;
        }

        public void HepifybottomToUp(int index )
        {  
             int parent  = index/2  ;  

            while (index > 1  && HeepArr[parent].Key < HeepArr[index].Key) // swap 
            {
                  
                KeyValuePair<int ,int> temp  = HeepArr[index] ;
                HeepArr[index ] = HeepArr[parent] ; 
                HeepArr[parent] = temp ; 
                index = parent ; 
                parent  = index/2 ; 
            }
        }
        public void Extract()// delet top elemnt 
        { 
            if(sizeOfTree == 1 ) return  ;  
               
             if(sizeOfTree == 2 ){ HeepArr[1]= new KeyValuePair<int, int>() ;   sizeOfTree--;    return ; }
               sizeOfTree--;  
             HeepArr[1] = HeepArr[sizeOfTree]  ;
             HeepArr[sizeOfTree] = new KeyValuePair<int, int>()  ;
             
             HeapifyTopToBottom( 1) ; 
        }
      void   HeapifyTopToBottom(int index )
        {
         int left  = index*2;  
        int right = (index*2)+1;  
        int smallestChild = 0;  
          
        if (sizeOfTree <= left) { //If there is no child of this node, then nothing to do. Just return.  
            return;   
        }else if (sizeOfTree == left+1) { //If there is only left child of this node, then do a comparison and return.  
            if(HeepArr[index].Key < HeepArr[left].Key) {  
                KeyValuePair<int , int> tmp = HeepArr[index];  
                HeepArr[index] = HeepArr[left];  
                HeepArr[left] = tmp;  
            }  
            return;  
        }else { //If both children are there  
            if(HeepArr[left].Key > HeepArr[right].Key) { //Find out the smallest child  
                smallestChild = left;  
            }else {  
                smallestChild = right;  
            }  
            if(HeepArr[index].Key <HeepArr[smallestChild].Key) { //If Parent is greater than smallest child, then swap  
                KeyValuePair<int, int> tmp = HeepArr[index];  
                HeepArr[index] = HeepArr[smallestChild];  
                HeepArr[smallestChild] = tmp;  
            }  
        }  
        HeapifyTopToBottom(smallestChild);  
     }
    }
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
          Heep MyHeap = new Heep(nums.Length); 
        foreach( KeyValuePair<int , int > x in lookup)
        {
           MyHeap.Insert(x.Value , x.Key) ;
        }
        int j = 0;
        while(j < k )
        {
          res[j] = MyHeap.peek() ; 
          MyHeap.Extract(); 
          j++;
        }

return res ; 
    }

}