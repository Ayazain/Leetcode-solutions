public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
         int Num = 0 ; 
		 int Max =  0  ; 
       
        Queue<KeyValuePair<int , int >> myqueue = new  Queue<KeyValuePair<int , int >>(); 
		 for (int i = 0 ; i < grid.Length ; i++ )
		 {
			 for (int j = 0 ; j < grid[0].Length ; j++)
			 {
			KeyValuePair<int , int > elemnt  =  new KeyValuePair<int , int >(i , j ); int x , y ;
				 if (grid[i][j] == 1)
				 {
					Num = 0 ; 
					 myqueue.Enqueue( elemnt); 
					grid[i][j] =5;
					 while (myqueue.Count > 0 )
					 {
						 Num++; 
						 
					 	KeyValuePair<int , int > newelemnt  =  myqueue.Dequeue() ; 
		            	x=newelemnt.Key ; 
		            	y = newelemnt.Value; 
						
						
						if(y>0 && grid[x][y-1] == 1)
						{
							grid[x][y-1] =5;
							 myqueue.Enqueue(new KeyValuePair<int , int >(x , y-1 )); 
						}
						if( y < grid[0].Length-1 && grid[x][y+1] == 1 )
						{
							 grid[x][y+1] = 5;
							 myqueue.Enqueue(new KeyValuePair<int , int >(x , y+1 )); 
						}
						  if(x> 0 && grid[x-1][y] == 1 )
						{
   							grid[x-1][y] =5 ;
							 myqueue.Enqueue(new KeyValuePair<int , int >(x-1 , y)); 
						}
						if(x < grid.Length-1 && grid[x+1][y] == 1)
						{
							grid[x+1][y] = 5;
							 myqueue.Enqueue(new KeyValuePair<int , int >(x+1 , y)); 
						}

					 }
			 if (Num > Max )
				 Max = Num ; 
				 }
                 Num = 0 ;
			 }
		 }
        return Max; 
        
    }
}