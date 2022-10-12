public class Solution {
 
   public  List<string> res = new List<string>();
      public  void LetterCasePermutationHelpper(string s, string Curr)
    {
        if (Curr.Length == s.Length) // base case 
        {
            res.Add(new String(Curr));
            return;
        }
        char c  = s[Curr.Length];
          
           LetterCasePermutationHelpper(s , new string( Curr+s[Curr.Length])) ;
          if (s[Curr.Length] >='a' && s[Curr.Length]<='z')
              c= Char.ToUpper(c);
         else if (s[Curr.Length] >='A' && s[Curr.Length]<='Z')
              c = Char.ToLower(c);
         else return;
          LetterCasePermutationHelpper(s ,  new string(Curr+c ) ) ;
    
        return  ; 
    }
    public   IList<string> LetterCasePermutation(string s)
    {
     LetterCasePermutationHelpper(s,"" );
    return res  ; 
    }
}