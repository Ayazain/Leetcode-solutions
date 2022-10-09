public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        if (n == 0 ) return tasks.Count() ;
          Dictionary<char, int> lookUp = new Dictionary<char, int>();
        PriorityQueue<char, int> myQueue; 
        for (int i = 0; i < tasks.Length; i++) // fill dic with num of rebetetion
        {
            if (lookUp.ContainsKey(tasks[i])) lookUp[tasks[i]]++;
            else lookUp.Add(tasks[i], 1);
        }
        myQueue = new PriorityQueue<char, int>(lookUp.Count);
        foreach (var x in lookUp)
        {
            myQueue.Enqueue(x.Key, 1 - x.Value);
        }
        char c  =  myQueue.Dequeue() ; 
        int Count  = lookUp[c]; int looklikeMe = 0  ; 
        while (myQueue.Count>0&&lookUp[myQueue.Dequeue()]== Count) looklikeMe++;
        int res  = ((n+1)*(Count-1)+1) ; //total for now 
        res+= looklikeMe ;
        int temp = res -Count ;// rest of me 
        if (tasks.Length-Count > temp)
              res += tasks.Length-Count -temp ; 
        
        return res ; 
    }
}