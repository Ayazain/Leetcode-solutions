public class Solution {
     public  int Check(string str1, string str2)
    {
        if (str1.Length != str2.Length) return 5;
        int c = 0;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i]) c++;
        }
        return c;
    }
    
    public int LadderLength(string src, string target, IList<string> words) {
           if (Check(src, target) == 0) return 0;

        Dictionary<string, bool> VisitedWords = new Dictionary<string, bool>(); //n
        Queue<KeyValuePair<string, int>> MyQueue = new Queue<KeyValuePair<string, int>>(); //n 
      
        MyQueue.Enqueue(new KeyValuePair<string, int>(src, 0)); 
        VisitedWords.Add(src, true);
        while (MyQueue.Count > 0) //n
        {
            KeyValuePair<string, int> working1 = MyQueue.Dequeue();
            string working = working1.Key;
          
            if (Check(working, target) == 0)//m
            {
                return working1.Value+1; 
            }

            for (int i = 0; i < words.Count; i++)
            {
                if (VisitedWords.ContainsKey(words[i])) continue;
                int ChecedVal = Check(words[i], working);
                if (ChecedVal == 1)
                { MyQueue.Enqueue(new KeyValuePair<string, int>(words[i], working1.Value + 1)); VisitedWords.Add(words[i], true); }
            }

        }
         
         return 0 ;
    }
}