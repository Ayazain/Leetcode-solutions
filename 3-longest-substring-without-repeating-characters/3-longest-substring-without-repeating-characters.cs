public class Solution {
    public int LengthOfLongestSubstring(string s)
      {
         Dictionary<char , int > mycharck = new Dictionary<char, int>(); 

        int max = int.MinValue ; 
        int myLength = 0;
        int startIndex  = 0   ;
        for (int EndIndex =  0  ; EndIndex < s.Length ;EndIndex++)
        {
          
            if (mycharck.ContainsKey(s[EndIndex]) && mycharck[s[EndIndex]]>=startIndex) 
            {
             int dubindex = mycharck[s[EndIndex]];
             myLength-= (dubindex-startIndex);
             mycharck[s[EndIndex]] = EndIndex; 
             startIndex = dubindex+1 ; 
            }
             else
            {
              if (mycharck.ContainsKey(s[EndIndex]) )
                     mycharck[s[EndIndex]] = EndIndex;
                  else
                mycharck.Add(s[EndIndex] , EndIndex); 
                myLength++; 
                max = Math.Max(myLength,max );
            } 
        }
        
        return Math.Max(myLength,max );
    }
}