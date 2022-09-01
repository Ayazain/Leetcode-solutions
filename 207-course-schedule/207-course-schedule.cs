public class Solution {
    int []haveEdges  ; 
   bool []REmoved   ; 
 Stack<int> nodes = new Stack<int>();
Queue<int> order = new Queue<int>();
 
    public bool CanFinish(int numCourses, int[][] prerequisites) {
         haveEdges = new int[numCourses]; 
    REmoved = new bool[numCourses];
    for (int i = 0 ; i < prerequisites.Length ; i++)
        haveEdges[prerequisites[i][0]]++;
     for(int i = 0 ; i < numCourses ; i++)
        {
            if(haveEdges[i]== 0)
           
            { 
                order.Enqueue(i); 
               
            }
        }
        
        while(order.Count>0)
        {
            
            int Eelement =  order.Dequeue();
             Console.WriteLine(Eelement);
            REmoved[Eelement]= true; 
             for (int i = 0 ; i < prerequisites.Length ; i++)
               if(prerequisites[i][1] == Eelement)
                 {
                     haveEdges[prerequisites[i][0]]--;
                     if(haveEdges[prerequisites[i][0]]== 0)
                      order.Enqueue(prerequisites[i][0]); 
                 }
        }
bool canfinish = true; ;
for (int i = 0 ; i < REmoved.Length ; i++)
        if(!REmoved[i]) canfinish = false;
   return canfinish ;        
    }
}