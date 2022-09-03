public class Solution {
   public int LengthOfLongestSubstring(string s)
      {
         Dictionary<char , int > mycharck = new Dictionary<char, int>(); 

        int max = int.MinValue ; 
        int myLength = 0;
        int startIndex  = 0   ;
        for (int EndIndex =  0  ; EndIndex < s.Length ;EndIndex++)
        {
            if(!mycharck.ContainsKey(s[EndIndex]))
            {
                mycharck.Add(s[EndIndex] , EndIndex); 
                myLength++; 
                max = Math.Max(myLength,max );
            } 
            else 
            {
             int dubindex = mycharck[s[EndIndex]];
             myLength-= (dubindex-startIndex);
             for (int i = startIndex ; i <dubindex ; i++ )
                  mycharck.Remove(s[i]);
                //mycharck.Add(s[EndIndex] , EndIndex); 
                mycharck[s[EndIndex]] = EndIndex; 
             startIndex = dubindex+1 ; 
            }
        }
        
        return Math.Max(myLength,max );
    }
}