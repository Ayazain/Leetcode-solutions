public class Solution {
    public  void GenerateParanthesHelpper(int n  , int open , int closes , string str )
{
    if (open == n &&open == closes ) {par.Add(str) ; return ; }
    if (open < n )
    { 
         open++;
        GenerateParanthesHelpper(n , open , closes , new String(str+'(')) ; 
        open--;
    }
    if(closes<open) 
    {
        closes++; 
          GenerateParanthesHelpper(n , open , closes , new String(str+')')) ; 
          closes--;
    }
}
  public  IList<string> par = new  List<string>(); 
  public  IList<string> GenerateParenthesis(int n) {
    
      GenerateParanthesHelpper(n ,0 , 0 , "");
return par ; 
    }
}