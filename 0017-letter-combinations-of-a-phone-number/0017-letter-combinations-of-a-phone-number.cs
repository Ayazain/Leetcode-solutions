public class Solution {
     public  List<string>res  = new List<string>() ; 
  public  void LetterCombinationsHelpper(string digits , int index  , string curr ) 
  {
    if (index == digits.Length)
    {
         res.Add(curr) ; return  ; 
    }
  
      for(int i = 0 ; i < LookUp[digits[index]].Length; i++)
         LetterCombinationsHelpper( digits ,  index+1  , new String(curr+LookUp[digits[index]][i]) ); 
    return ; 
  }  
public   Dictionary<char , char[] > LookUp  = new Dictionary<char, char[]>() ;
public  IList<string> LetterCombinations(string digits) {
    if (digits.Length == 0 ) return res;
      LookUp.Add('2' , new char[]{'a','b','c'}) ;
      LookUp.Add('3' , new char[]{'d','e','f'}) ;

      LookUp.Add('4' , new char[]{'g','h','i'}) ;

      LookUp.Add('5' , new char[]{'j','k','l'}) ;
   
      LookUp.Add('6', new char[]{'m','n','o'}) ;
      LookUp.Add('7' , new char[]{'p','q','r','s'}) ;
      LookUp.Add('8' , new char[]{'t','u','v'}) ;
      LookUp.Add('9' , new char[]{'w','x','y','z'}) ;
      LetterCombinationsHelpper(digits , 0  , "");
      return res ;
}
}