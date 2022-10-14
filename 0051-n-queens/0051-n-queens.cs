public class Solution {
  public  List<IList<string>> res  = new List<IList<string>>();
 public  List<string> All = new List<string>() ; 
  public  IList<IList<string>> SolveNQueens(int n) {
        Char []arr =  new char[n];   
       for(int i = 0 ; i < n  ; i++ )
          {
            arr[i]='.';
          }
          for (int i = 0 ; i < n ; i++)
          {
            arr[i]='Q'; 
            All.Add( new String(arr)); 
            arr[i] = '.';
          }

  SolveNQueensHelpper(new int [n] , n-1 ,  new List<string>()  , new Dictionary<int, bool>() , new Dictionary<int, bool>()  );
  return res ;
    }

public  void SolveNQueensHelpper(int [] colomns  , int row  ,  List<string> curr , Dictionary<int , bool >NDigonal  , Dictionary<int ,bool>PDigonal )
{
    if ( row < 0 )
    { 
        res.Add(new List<string>(curr)); 
    }
    for (int i = colomns.Length-1  ; i  >=0 ; i--)
    {
        if (colomns[i] != -1 &&!NDigonal.ContainsKey(row-i) && !PDigonal.ContainsKey(row+i))
        {
         colomns[i]=-1;
        curr.Add(new String( All[i])) ; 
        NDigonal.Add(row-i , true );
        PDigonal.Add(row+i, true ); 
        SolveNQueensHelpper(colomns , row-1 , curr, NDigonal , PDigonal) ; 
        curr.RemoveAt(curr.Count-1);
        NDigonal.Remove(row-i );
        PDigonal.Remove(row+ i );
        colomns[i] = 0; 
        } 
    }
    return ; 
}

}