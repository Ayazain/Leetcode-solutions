public class Solution {
    public int NumIslands(char[][] grid) {
         int Num = 0 ; 
        Queue<KeyValuePair<int , int >> myqueue = new  Queue<KeyValuePair<int , int >>(); 
		 for (int i = 0 ; i < grid.Length ; i++ )
		 {
			 for (int j = 0 ; j < grid[0].Length ; j++)
			 {
			KeyValuePair<int , int > elemnt  =  new KeyValuePair<int , int >(i , j ); int x , y ;
				 if (grid[i][j] == '1')
				 {
					Num++; 
					 myqueue.Enqueue( elemnt); 
			        	grid[i][j] ='x';
					 while (myqueue.Count > 0 )
					 {
					 	KeyValuePair<int , int > newelemnt  =  myqueue.Dequeue() ; 
		            	x=newelemnt.Key ; 
		            	y = newelemnt.Value; 
						Console.WriteLine(x+  "   " + y    +"       " +grid.Length +"     " +grid[0].GetLength(0)  );
						
						if(y>0 && grid[x][y-1] == '1')
						{
							grid[x][y-1] ='x';
							 myqueue.Enqueue(new KeyValuePair<int , int >(x , y-1 )); 
						}
						if( y < grid[0].Length-1 && grid[x][y+1] == '1' )
						{
							 grid[x][y+1] = 'x';
							 myqueue.Enqueue(new KeyValuePair<int , int >(x , y+1 )); 
						}
						  if(x> 0 && grid[x-1][y] == '1' )
						{
   							grid[x-1][y] ='x' ;
							 myqueue.Enqueue(new KeyValuePair<int , int >(x-1 , y)); 
						}
						if(x < grid.Length-1 && grid[x+1][y] == '1')
						{
							grid[x+1][y] = 'x';
							 myqueue.Enqueue(new KeyValuePair<int , int >(x+1 , y)); 
						}

					 }
			 
				 }
			 }
		 }
        return Num;  
    }
}