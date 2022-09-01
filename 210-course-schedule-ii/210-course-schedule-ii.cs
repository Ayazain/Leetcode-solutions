public class Solution {
      int[] haveEdges;
    bool[] REmoved;
    List<int> nodes = new List<int>();
    Queue<int> order = new Queue<int>();
    Dictionary<int, List<int>> Mynodes;

    public int[] FindOrder(int numCourses, int[][] prerequisites) {
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
            //Console.WriteLine( "Key = "+ prerequisites[i][1]+"val = "+ prerequisites[i][0]);
             haveEdges[prerequisites[i][0]]++;
        }       
        for (int i = 0; i < numCourses; i++)
        {
            if (haveEdges[i] == 0)

            {
                order.Enqueue(i);

            }
        }



        while (order.Count > 0)
        {
            int Eelement = order.Dequeue();
            nodes.Add(Eelement);

            for (int i = 0; i < Mynodes[Eelement].Count; i++)
            {
                haveEdges[Mynodes[Eelement][i]]--;
                if (haveEdges[Mynodes[Eelement][i]] == 0)
                    order.Enqueue(Mynodes[Eelement][i]);
            }
            Mynodes.Remove(Eelement);

        }

         if (Mynodes.Count==0)
        return nodes.ToArray();
        else 
        return new List<int>().ToArray();
    }
}