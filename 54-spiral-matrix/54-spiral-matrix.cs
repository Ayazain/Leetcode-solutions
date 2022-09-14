public class Solution {
    public IList<int> SpiralOrder(int[][] inputMatrix) {
          int [] copy  = new int [inputMatrix.Count() * inputMatrix[0].Count()] ;
      int numRows = inputMatrix.Count();
      int numCols = inputMatrix[0].Count();
      
      int topRow = 0;
      int bottomRow = numRows -1; 
      int leftCol  = 0;
      int rightCol = numCols-1;
      int counter = 0; 

      //System.IndexOutOfRangeException : Index was outside the bounds of the array.

      
     while (topRow <= bottomRow || leftCol <= rightCol)
      {
       if (topRow <= bottomRow)
       {
        for (int i =  leftCol ; i<=  rightCol ; i++ , counter++)
        { copy[counter] = inputMatrix[topRow][i] ; Console.WriteLine(copy[counter]);}  
          topRow++;
        }
         if (leftCol <= rightCol)
         {
        for (int n = topRow ; n<= bottomRow; n++,counter++)
        { copy[counter] = inputMatrix[ n ][ rightCol ] ; Console.WriteLine("jj"+copy[counter]);}
           rightCol--;; 
         }
      if(bottomRow >=  topRow)
        {  
             for (int n =  rightCol ; n>=  leftCol ; n-- ,  counter++)
        { copy[counter] = inputMatrix[ bottomRow ][ n  ] ;   Console.WriteLine(copy[counter]);}
         bottomRow--;
        }
       
        if(leftCol<=rightCol)
        { for (int n =  bottomRow ; n>=  topRow ; n-- , counter++)
        { copy[counter] = inputMatrix[ n ][ leftCol  ] ;   Console.WriteLine(copy[counter]);}
          leftCol++; 
        }
        
    
      }
      return copy; 
    }
}