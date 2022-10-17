public class Solution {
 public  IList<int> FindMinHeightTrees(int n, int[][] edges) {
     int min = int.MaxValue  ;  
        List<int > Min  = new List<int>() ; 
    if (edges.LongLength    == 0   ) { Min.Add(0); return Min;}  ; 
     List<int>[] Graph = new List<int> [n] ; 
        Queue<KeyValuePair<int , int > > HasOnlyOneDependices = new Queue<KeyValuePair<int, int>>(); 
        for (int i = 0  ; i < edges.Length; i++ ) //  array of list  each elemnt represent a Node  and the list represect Neibours 
        {
         if (Graph [edges[i][0]] == null  )
             { Graph [edges[i][0]] = new List<int>(); }
              Graph [edges[i][0]].Add(edges[i][1]); 

         if (Graph [edges[i][1]] == null  )
             { Graph [edges[i][1]] = new List<int>(); }
              Graph [edges[i][1]].Add(edges[i][0]); 
     
        }
         for (int i = 0  ; i < Graph.Length; i++ ) //   Get all elemnt has onle one depeness  
        {
           if (Graph[i].Count == 1 )
            HasOnlyOneDependices.Enqueue( new KeyValuePair<int, int>(i , 0) ); 
        }
        int Num = Graph.Length ; 
        while(Num > 2)
        {
         KeyValuePair<int , int > mynode = HasOnlyOneDependices.Dequeue();
         Num--;
         for (int i = 0  ; i < Graph[mynode.Key].Count; i++)
         {
           Graph[ Graph[mynode.Key][i] ].Remove(mynode.Key);
           if ( Graph[ Graph[mynode.Key][i] ].Count <=1 )
              HasOnlyOneDependices.Enqueue( new KeyValuePair<int, int>(Graph[mynode.Key][i]  , mynode.Value+1 ) ); 
         }
        }


              KeyValuePair< int , int >  FElemnt =   HasOnlyOneDependices.Dequeue(); 
              KeyValuePair< int , int >  SElemnt =   HasOnlyOneDependices.Dequeue(); 
             if (FElemnt.Value == SElemnt.Value)
             {
               Min.Add(SElemnt.Key); 
               Min.Add(FElemnt.Key);
             }
             else Min.Add(SElemnt.Key);
             return Min ; 
           
    }

    private static int GetHight(List<int>[] graph, int index , int prev  , Dictionary< KeyValuePair<int , int > , int >lookup)
    {

    if (lookup.ContainsKey(new KeyValuePair<int, int>(index, prev)))
       return lookup[new KeyValuePair<int, int>(index , prev)];
         int hight = 0  ;   
        for (int i = 0 ; i < graph[index].Count ; i++ )
        {
           if (prev != graph[index][i])
          hight = Math.Max( GetHight(graph , graph[index][i], index,lookup), hight   ) ;
        }
        lookup.Add(new KeyValuePair<int, int>(index , prev) , hight +1  );
        return hight +1 ; 
    }
}