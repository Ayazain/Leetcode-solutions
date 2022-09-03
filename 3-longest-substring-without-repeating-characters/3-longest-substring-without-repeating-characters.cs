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
               Console.WriteLine("right   "+ EndIndex + "   "+ s[EndIndex]);   
                mycharck.Add(s[EndIndex] , EndIndex); 
                myLength++; 
                max = Math.Max(myLength,max );
              Console.WriteLine( "len  = "+ myLength) ;
            } 
            else 
            {
            Console.WriteLine("False    "+ EndIndex + "   "+ s[EndIndex]);   

             int dubindex = mycharck[s[EndIndex]];
             myLength-= (dubindex-startIndex);
                Console.WriteLine( "len  = "+ myLength) ;
             for (int i = startIndex ; i <=dubindex ; i++ )
                  mycharck.Remove(s[i]);
                 mycharck.Add(s[EndIndex] , EndIndex); 
             startIndex = dubindex+1 ; 
          
            }
        }
        
        return Math.Max(myLength,max );
    }
}