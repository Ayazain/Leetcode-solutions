using System ; 
using System.Collections.Generic;
public class Solution {

    public   int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
	{
        
        int color = image[sr][sc]; 
        if (color == newColor)
            return image ; 
        image[sr][sc] = newColor ; 
     //   List<KeyValuePair<int , int >> visited  = new List <KeyValuePair<int , int >>();
        Queue<KeyValuePair<int , int >> myqueue = new  Queue<KeyValuePair<int , int >>(); 
		
        myqueue.Enqueue(new KeyValuePair<int , int >(sr , sc )); 
        int x = sr , y = sc ; 
		while (myqueue.Count >  0 )
		{
			
			//check nighbours 
			KeyValuePair<int , int > elemnt  =  myqueue.Dequeue() ; 
			x=elemnt.Key ; 
			y = elemnt.Value; 
	
            if(y>0 && image[x][y-1] == color  )
            {
                image[x][y-1] = newColor; 
                 myqueue.Enqueue(new KeyValuePair<int , int >(x , y-1 )); 
            }
            if( y < image[0].Length-1 && image[x][y+1] == color)
            {
                image[x][y+1] = newColor; 
                 myqueue.Enqueue(new KeyValuePair<int , int >(x , y+1 )); 
            }
		        if(x> 0 && image[x-1][y] == color)
            {
                image[x-1][y] = newColor; 
                 myqueue.Enqueue(new KeyValuePair<int , int >(x-1 , y)); 
            }
            if(x < image.Length-1 && image[x+1][y] == color)
            {
                image[x+1][y] = newColor; 
                 myqueue.Enqueue(new KeyValuePair<int , int >(x+1 , y)); 
            }
                    
		}
      
		return image ;
    }
    
    
}
