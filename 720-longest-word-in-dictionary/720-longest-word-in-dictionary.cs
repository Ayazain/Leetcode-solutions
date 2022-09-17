public class Solution {
    public  string LongestWord(string[] words) {
        Array.Sort(words , (a,b)=> a.Length.CompareTo(b.Length)); 
        Dictionary<string , int >newwords = new Dictionary<string, int>(); 
        int Max  = int.MinValue ; int index = 0;
         for(int i= 0 ; i <words.Length ; i++ ) 
          if (!newwords.ContainsKey(words[i]))
             newwords.Add(words[i] , words.Length);
        
        for (int i = words.Length-1 ; i >=0 ; i-- )
         {
            string s = words[i]; int counter = 0;  
            while(s.Length>=1 && newwords.ContainsKey(s))
            {
             s = words[i].Substring(0, s.Length-1); 
             counter++; 
            }
            
            if (counter ==words[i].Length && counter >=Max)
            {
                 if (counter == Max)
                {
                   if( string.Compare(words[i], words[index])!= -1)
                   continue;
                }
                Max = counter  ;  
                index = i ; 
            }
         }   
         return   (Max  == int.MinValue)?"":words[index];;

    }
}