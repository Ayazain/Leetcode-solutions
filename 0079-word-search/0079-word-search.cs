public class Solution {
   public  bool CanIFind(KeyValuePair<int ,int > StartFrom  ,int index , string word , char[][] board  )
    {
        if (word.Length== index) return true  ; 
        int i = StartFrom.Key ; 
        int j  = StartFrom.Value ; char temp =  board[i][j] ; board[i][j] = '$'; 
        if (StartFrom.Key >0  && board[i-1][j]== word[index])
          if ( CanIFind(new KeyValuePair<int, int>(i-1,j) , index+1, word, board  ) ) return true ; 
        
         if (StartFrom.Key <board.Length -1&& board[i+1][j]== word[index])
          if (  CanIFind(new KeyValuePair<int, int>(i+1,j) , index+1, word, board ) ) return true ;

            
         if (StartFrom.Value > 0 && board[i][j-1]== word[index])
         if (CanIFind(new KeyValuePair<int, int>(i,j-1) , index+1, word, board )) return true ;  ;

            
         if (StartFrom.Value <board[StartFrom.Key].Length -1&& board[i][j+1]== word[index])
         if ( CanIFind(new KeyValuePair<int, int>(i,j+1) , index+1, word, board )) return true  ;
         board[i][j] = temp ;  
   return false ;
    }
    public  bool Exist(char[][] board, string word) {
        for (int i = 0  ; i < board.Length ;i++)
        {
            for (int j = 0 ; j < board[i].Length ; j++ )
            {
                if (word[0]== board[i][j]) 
                if (CanIFind(new KeyValuePair<int, int>(i , j ) , 1 , word , board)) return true ; 
            }
        }
        return false ; 
    }

}