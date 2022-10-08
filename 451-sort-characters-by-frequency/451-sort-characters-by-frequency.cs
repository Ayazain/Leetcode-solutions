public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> lookup = new Dictionary<char, int>() ;
          PriorityQueue<char, int> myqueue ; 
          char[] str  =  new char[s.Length] ;   char c ;  int j = 0 ; 
           for (int i = 0  ; i < s.Length ; i++ )
           {
            if (lookup.ContainsKey(s[i])) lookup[s[i]]++ ; 
            else lookup.Add(s[i],1);
           }
           myqueue = new PriorityQueue<char, int>(lookup.Count + 1);
           foreach(var x in lookup)
           {
             c = x.Key ; 
             int count = x.Value ; 
             myqueue.Enqueue(x.Key , 1-x.Value);
           }
           while(myqueue.Count>0 )
           {
           c  =myqueue.Dequeue();
           for (int i = 0 ; i < lookup[c] ; i++, j++) { str[j]=c; } 
           }
         
           return new string (str) ; 
    }
}