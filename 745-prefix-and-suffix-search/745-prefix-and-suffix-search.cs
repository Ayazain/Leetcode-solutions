public class WordFilter {
 public class Trie {
        Dictionary<char, Trie >  Child; 
        bool IsEnd;
        List<int> index ;
    public Trie() {
         Child = new   Dictionary<char, Trie >(); 
         IsEnd = false ; 
         index= new List<int>();
    }
     public Trie(bool _IsEnd)
        {
            Child = new   Dictionary<char, Trie >();
            IsEnd = _IsEnd ; 
            index= new List<int>() ; 
        }
    public void Insert(string word, int myindex ) 
    {
      Trie Start = this ; 
        for(int i = 0 ; i < word.Length ; i++)
        {
     
       if (!Start.Child.ContainsKey(word[i]))
              Start.Child.Add(word[i] ,new Trie( (i >= word.Length-1)?true:false));
              
       else 
            if(i == word.Length-1 ){Start.Child[word[i]].IsEnd = true;  }

       Start = Start.Child[word[i]]; 
       Start.index.Add(myindex);
        }
       
    }
     public void InsertReversed(string word, int myindex ) 
    {
      Trie Start = this ; 
        for(int i = word.Length-1 ; i >=0 ; i--)
        {
     
       if (!Start.Child.ContainsKey(word[i]))
              Start.Child.Add(word[i] ,new Trie( (i == 0 )?true:false));
              
       else 
            if(i == 0 ){Start.Child[word[i]].IsEnd = true;  }

       Start = Start.Child[word[i]]; 
       Start.index.Add(myindex);
        }
       
    }

    public bool Search(string word) {
         Trie Start = this ; 
        for(int i = 0 ; i <  word.Length ; i++)
        {
        if (Start.Child.ContainsKey(word[i]))
            Start = Start.Child[word[i]];
          else 
              return false ;
        }
     if (Start.IsEnd)
        return true ;
        return false ;
    }
    
    public List<int> StartsWith(string prefix) {
        Trie Start = this ;
        for(int i = 0 ; i <  prefix.Length ; i++)
        {
        if (Start.Child.ContainsKey(prefix[i]))
            Start = Start.Child[prefix[i]];
          else 
              return new List<int>() ;
        }
        return Start.index  ;
    }
      public List<int> EndWith(string suff) {
        Trie Start = this ;
        for(int i = suff.Length-1 ; i >=0 ; i--)
        {
        if (Start.Child.ContainsKey(suff[i]))
            Start = Start.Child[suff[i]];
          else 
              return new List<int>() ;
        }
     
        return Start.index  ;
    }
 }
     Trie Start ;
    Trie end ;  
      Dictionary<string , int > InsertMEmo ; 
      Dictionary<string , List<int> > PrefMEmo ; 
      Dictionary<string , List<int> > SuffMEmo ; 

    public    WordFilter(string[] words) {
            Start = new Trie();
            end = new Trie() ;
            InsertMEmo = new Dictionary<string, int>(); 
            PrefMEmo = new Dictionary<string, List<int>>() ; 
            SuffMEmo = new Dictionary<string, List<int>>() ;
        for(int i = words.Length-1 ; i >= 0  ; i--)
          {
            if (!InsertMEmo.ContainsKey(words[i])){
                Start.Insert(words[i], i );
                end.InsertReversed(words[i], i);
                 InsertMEmo.Add(words[i], i); }
          }
    }
  public  int F(string pref, string suff) {
         List<int> strats , ends ;
       if(!PrefMEmo.ContainsKey(pref))
          {  strats = Start.StartsWith(pref) ; PrefMEmo.Add(pref , strats) ; }
        if(!SuffMEmo.ContainsKey(suff))
            { ends = end.EndWith(suff) ; SuffMEmo.Add(suff, ends ); }
        strats = PrefMEmo[pref]; 
        ends = SuffMEmo[suff];
       List<int> Res =  strats.Intersect(ends).ToList();
      return (Res.Count>0)?Res.Max():-1 ;
    }
}

/**
 * Your WordFilter object will be instantiated and called as such:
 * WordFilter obj = new WordFilter(words);
 * int param_1 = obj.F(pref,suff);
 */