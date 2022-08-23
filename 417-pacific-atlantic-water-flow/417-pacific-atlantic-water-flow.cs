public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        IList<IList<int>> ret = new List<IList<int>>();
        Queue<KeyValuePair<int, int>> Atlantic = new Queue<KeyValuePair<int, int>>();
        Queue<KeyValuePair<int, int>> Pacific = new Queue<KeyValuePair<int, int>>();
        Dictionary<KeyValuePair<int , int >, bool> VistedAtlantic = new Dictionary<KeyValuePair<int, int>, bool>();
         Dictionary<KeyValuePair<int , int >, bool> VistedPacific = new Dictionary<KeyValuePair<int, int>, bool>();
        int Rows = heights.Length;
        int colomns = heights[0].Length;
        for (int i = 0; i < colomns; i++)
        {
            Pacific.Enqueue(new KeyValuePair<int, int>(0, i));
            VistedPacific.Add(new KeyValuePair<int, int>(0,i) , true);
            Atlantic.Enqueue(new KeyValuePair<int, int>(Rows - 1, i));
            VistedAtlantic.Add(new KeyValuePair<int, int>(Rows-1,i ),true);

        }
        for (int i = 1; i < Rows; i++)
        {
            Pacific.Enqueue(new KeyValuePair<int, int>(i, 0));
            VistedPacific.Add(new KeyValuePair<int, int>(i,0),true);
            Atlantic.Enqueue(new KeyValuePair<int, int>(i - 1, colomns - 1));
            VistedAtlantic.Add( new KeyValuePair<int, int>( i-1,colomns - 1),true);
        }
        while (Atlantic.Count > 0)
        {
         KeyValuePair<int , int> mynode = Atlantic.Dequeue();
         if(mynode.Key > 0)
         {
            if(heights[mynode.Key-1][mynode.Value]>= heights[mynode.Key][mynode.Value])
            {
               if(!VistedAtlantic.ContainsKey( new KeyValuePair<int , int >( mynode.Key-1 , mynode.Value)))
               {
                   Atlantic.Enqueue(new KeyValuePair<int, int>(mynode.Key-1 , mynode.Value));
                   VistedAtlantic.Add( new KeyValuePair<int, int>( mynode.Key-1 , mynode.Value),true);
               }
            }
         }
           if(mynode.Key < Rows-1)
         {
            if(heights[mynode.Key+1][mynode.Value]>= heights[mynode.Key][mynode.Value])
            {
               if(!VistedAtlantic.ContainsKey( new KeyValuePair<int , int >( mynode.Key+1 , mynode.Value)))
               {
                   Atlantic.Enqueue(new KeyValuePair<int, int>(mynode.Key+1 , mynode.Value));
                   VistedAtlantic.Add( new KeyValuePair<int, int>( mynode.Key+1 , mynode.Value),true);
               }
            }
         }
           if(mynode.Value > 0)
         {
            if(heights[mynode.Key][mynode.Value-1]>= heights[mynode.Key][mynode.Value])
            {
               if(!VistedAtlantic.ContainsKey( new KeyValuePair<int , int >( mynode.Key , mynode.Value-1)))
               {
                   Atlantic.Enqueue(new KeyValuePair<int, int>(mynode.Key , mynode.Value-1));
                   VistedAtlantic.Add( new KeyValuePair<int, int>( mynode.Key , mynode.Value-1),true);
               }
            }
         }
            if(mynode.Value < colomns-1)
         {
            if(heights[mynode.Key][mynode.Value+1]>= heights[mynode.Key][mynode.Value])
            {
               if(!VistedAtlantic.ContainsKey( new KeyValuePair<int , int >( mynode.Key , mynode.Value+1)))
               {
                   Atlantic.Enqueue(new KeyValuePair<int, int>(mynode.Key , mynode.Value+1));
                   VistedAtlantic.Add( new KeyValuePair<int, int>( mynode.Key , mynode.Value+1),true);
               }
            }
         }
        }
         while (Pacific.Count > 0)
        {
         KeyValuePair<int , int> mynode = Pacific.Dequeue();
         if(mynode.Key > 0)
         {
            if(heights[mynode.Key-1][mynode.Value]>= heights[mynode.Key][mynode.Value])
            {
               if(!VistedPacific.ContainsKey( new KeyValuePair<int , int >( mynode.Key-1 , mynode.Value)))
               {
                   Pacific.Enqueue(new KeyValuePair<int, int>(mynode.Key-1 , mynode.Value));
                   VistedPacific.Add( new KeyValuePair<int, int>( mynode.Key-1 , mynode.Value),true);
               }
            }
         }
           if(mynode.Key < Rows-1)
         {
            if(heights[mynode.Key+1][mynode.Value]>= heights[mynode.Key][mynode.Value])
            {
               if(!VistedPacific.ContainsKey( new KeyValuePair<int , int >( mynode.Key+1 , mynode.Value)))
               {
                   Pacific.Enqueue(new KeyValuePair<int, int>(mynode.Key+1 , mynode.Value));
                   VistedPacific.Add( new KeyValuePair<int, int>( mynode.Key+1 , mynode.Value),true);
               }
            }
         }
           if(mynode.Value > 0)
         {
            if(heights[mynode.Key][mynode.Value-1]>= heights[mynode.Key][mynode.Value])
            {
               if(!VistedPacific.ContainsKey( new KeyValuePair<int , int >( mynode.Key , mynode.Value-1)))
               {
                   Pacific.Enqueue(new KeyValuePair<int, int>(mynode.Key , mynode.Value-1));
                   VistedPacific.Add( new KeyValuePair<int, int>( mynode.Key , mynode.Value-1),true);
               }
            }
         }
            if(mynode.Value < colomns-1)
         {
            if(heights[mynode.Key][mynode.Value+1]>= heights[mynode.Key][mynode.Value])
            {
               if(!VistedPacific.ContainsKey( new KeyValuePair<int , int >( mynode.Key , mynode.Value+1)))
               {
                   Pacific.Enqueue(new KeyValuePair<int, int>(mynode.Key , mynode.Value+1));
                   VistedPacific.Add( new KeyValuePair<int, int>( mynode.Key , mynode.Value+1),true);
               }
            }
         }
        }
        foreach(var  x   in VistedPacific)
        {
        if(VistedAtlantic.ContainsKey(x.Key))
        ret.Add (new List<int>{x.Key.Key , x.Key.Value});

        }

       return ret;
    }   
    
}