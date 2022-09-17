public class Solution {
   public class Trie
    {
        Dictionary<char, Trie> Child;
        bool IsEnd;
        public Trie()
        {
            Child = new Dictionary<char, Trie>();
            IsEnd = false;
        }
        public Trie(bool _IsEnd)
        {
            Child = new Dictionary<char, Trie>();
            IsEnd = _IsEnd;
        }
        public int Insert(string word)
        {
            Trie Start = this; int count = 0; bool iterative = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (!Start.Child.ContainsKey(word[i]))
                {
                    if (i != word.Length - 1)
                        iterative = false;
                    else
                        count++;
                    Start.Child.Add(word[i], new Trie((i >= word.Length - 1) ? true : false));
                }
                else
                {
                    if (Start.Child[word[i]].IsEnd) count++;
                    if (i == word.Length - 1) Start.Child[word[i]].IsEnd = true;
                }
                Start = Start.Child[word[i]];
            }
            if (!iterative) return -1;
            else
                return count;
        }
      
    }

    public  string LongestWord(string[] words)
    {
        Trie start = new Trie();
        Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length));
        int max = -1;
        string word = "";
        for (int i = 0; i < words.Length; i++)
        {
            int c = start.Insert(words[i]);
            if (c == words[i].Length)
                {
                    if (c > max) { word = words[i]; max = c; }
                    else if (c == max)
                    {
                        if (word.CompareTo(words[i]) == 1)
                            word = words[i];
                    }
                }
        }
        return word;
    }
}