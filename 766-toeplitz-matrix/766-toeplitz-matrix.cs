public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
     
        for (int i =  1 ; i < matrix.Length ;i++)
        {
            int j = i ; int c =0 ;
            while (  c< matrix[0].Length-1 )
            {
                if (matrix[i-1][c] != matrix[i][c+1])return false ;
                j++; c++;
            }
        
            
        }
          return true ;   
    }
}