public class Solution {
    public string ReorganizeString(string s) {
      Dictionary<char, int> lookup = new Dictionary<char, int>() ;
           PriorityQueue<char, int> myqueue = new PriorityQueue<char, int>(s.Length + 1);
            char []  chararr = new char[s.Length];
           for (int i = 0  ; i < s.Length ; i++ )
           {
            if (lookup.ContainsKey(s[i])) lookup[s[i]]++ ; 
            else lookup.Add(s[i],1);
           }
           foreach(var x in lookup)
           {
            myqueue.Enqueue(x.Key ,s.Length- x.Value);
           }
           int index =  0 ; 
           while (myqueue.Count> 0 )
           {
             char c = myqueue.Dequeue() ; 
             int count = lookup[c];
             if (count > (s.Length+1)/2) return"";
             while (count > 0  )
             {
                count--;
                if(index >=s.Length)index=1;
                chararr[index] = c ; 
                index+=2 ; 
             }
           }
           return new string( chararr)  ; 
    }
}