using System.Collections.Generic; 
public class Trie {
        Dictionary<char, Trie >  Child; 
        bool IsEnd;
    public Trie() {
         Child = new   Dictionary<char, Trie >(); 
         IsEnd = false ; 
    }
     public Trie(bool _IsEnd)
        {
            Child = new   Dictionary<char, Trie >();
            IsEnd = _IsEnd ; 
        }
    public void Insert(string word) 
    {
      Trie Start = this ; 
        for(int i = 0 ; i < word.Length ; i++)
        {
     
       if (!Start.Child.ContainsKey(word[i]))
          Start.Child.Add(word[i] ,new Trie( (i >= word.Length-1)?true:false));
       else 
            if(i == word.Length-1 )Start.Child[word[i]].IsEnd = true;
       Start = Start.Child[word[i]]; 
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
    
    public bool StartsWith(string prefix) {
        Trie Start = this ; 
        for(int i = 0 ; i <  prefix.Length ; i++)
        {
        if (Start.Child.ContainsKey(prefix[i]))
            Start = Start.Child[prefix[i]];
          else 
              return false ;
        }
  
        return true  ;

  
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */