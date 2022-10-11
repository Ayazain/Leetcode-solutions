public class Solution {
 public   int   FindPath(int[][] obstacleGrid  )
{
  for (int i = obstacleGrid.Length-1 ; i>=0 ; i--)
  {
    for (int j = obstacleGrid[i].Length-1 ; j>=0 ;j--)
    {
        if (obstacleGrid[i][j]== 0)
        {
        if (i<obstacleGrid.Length-1) obstacleGrid[i][j]+=Math.Max(obstacleGrid[i+1][j], 0) ;
        if (j<obstacleGrid[i].Length-1) obstacleGrid[i][j]+=Math.Max(obstacleGrid[i][j+1], 0) ;
        }
        
    }
  }
  return obstacleGrid[0][0];
}
   public   int UniquePathsWithObstacles(int[][] obstacleGrid) {
     for (int i = 0  ; i < obstacleGrid.Length ; i++ )
         for (int j = 0 ; j < obstacleGrid[i].Length ; j++)
           obstacleGrid[i][j]= (obstacleGrid[i][j]==1)?-1: 0;
        
         int  I =  obstacleGrid.Length-1, J = obstacleGrid[0].Length-1;
           if (obstacleGrid[I][J] ==0   )obstacleGrid[I][J] = 1 ; else return 0;
    FindPath(obstacleGrid );
    return Math.Max(obstacleGrid[0][0], 0); 
    }
}