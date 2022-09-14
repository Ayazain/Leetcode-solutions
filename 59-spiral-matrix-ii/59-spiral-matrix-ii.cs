public class Solution {
   public  int[][] GenerateMatrix(int num ) {
         
         int[][] inputMatrix = new int [num][];
         for (int i = 0 ;i < num ; i++)inputMatrix[i]= new int [num];  
      int topRow = 0;
      int bottomRow = num -1; 
      int leftCol  = 0;
      int rightCol =num-1;
      int counter = 1; 

      //System.IndexOutOfRangeException : Index was outside the bounds of the array.

      
         while (topRow <= bottomRow ||  leftCol <= rightCol)
      {
       if (topRow <= bottomRow)
       {
        for (int i =  leftCol ; i<=  rightCol ; i++ , counter++) inputMatrix[topRow][i] = counter ;   
          topRow++;
        }
         if (leftCol <= rightCol)
         {
        for (int n = topRow ; n<= bottomRow; n++,counter++) inputMatrix[ n ][ rightCol ] = counter   ;
           rightCol--;; 
         }
      if(bottomRow >=  topRow)
        {  
             for (int n =  rightCol ; n>=  leftCol ; n-- ,  counter++) inputMatrix[ bottomRow ][ n  ] = counter;   
         bottomRow--;
        }
       
        if(leftCol<=rightCol)
        { for (int n =  bottomRow ; n>=  topRow ; n-- , counter++) inputMatrix[ n ][ leftCol  ] = counter ; 
          leftCol++; 
        }
        
    
      }
      return inputMatrix; 
    }
}