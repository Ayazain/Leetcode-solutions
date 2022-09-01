public class Solution {
    int []haveEdges  ; 
   bool []REmoved   ; 
 Stack<int> nodes = new Stack<int>();
      Dictionary<int, List<int>> Mynodes;
Queue<int> order = new Queue<int>();
 
    public bool CanFinish(int numCourses, int[][] prerequisites) {
          Mynodes = new Dictionary<int, List<int>>();
        haveEdges = new int[numCourses];
        REmoved = new bool[numCourses];
        for (int i = 0; i < numCourses; i++)
        {
            Mynodes.Add(i, new List<int>());
        }
        for (int i = 0; i < prerequisites.Length; i++)
        {
            Mynodes[prerequisites[i][1]].Add(prerequisites[i][0]);
        }
        foreach (var item in Mynodes)
        {
            if (item.Value.Count == 0)
                order.Enqueue(item.Key);

        }
        for (int i = 0; i < prerequisites.Length; i++)
            haveEdges[prerequisites[i][0]]++;
        for (int i = 0; i < numCourses; i++)
        {
            if (haveEdges[i] == 0)
                order.Enqueue(i);
        }
        while (order.Count > 0)
        {
            int Eelement = order.Dequeue();
            REmoved[Eelement] = true;
             
            for (int i = 0; i < Mynodes[Eelement].Count; i++)
                {
                    haveEdges[ Mynodes[Eelement][i]]--;
                    if (haveEdges[ Mynodes[Eelement][i]] == 0)
                        order.Enqueue( Mynodes[Eelement][i]);
                }
                
        }
        bool canfinish = true; ;
        for (int i = 0; i < REmoved.Length; i++)
            if (!REmoved[i]) canfinish = false;
        return canfinish;      
    }
}