public class Solution {
    public IList<string> FindAllConcatenatedWordsInADict(string[] words)
    {
        Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length)); //  sort array  
        Dictionary<string, bool> lookup = new Dictionary<string, bool>(); //  map all valid strings 
        IList<string> res = new List<string>();
        foreach (string str in words)
            lookup.Add(str, true);

        for (int i = 0; i < words.Length; i++)
        {
            if (goodword(words[i], true, lookup))
            {
                res.Add(words[i]);
            }
        }
        return res;
    }

    public bool goodword(string str, bool isOriginal, Dictionary<string, bool> lookup)
    {
        if (!isOriginal && lookup.ContainsKey(str))
            return true;
        for (int i = 0; i < str.Length; i++)
        {
            string left = str.Substring(0, i);
            string Right = str.Substring(i);
            if (lookup.ContainsKey(left) && goodword(Right, false, lookup))
            {
               if (!lookup.ContainsKey(str )) lookup.Add(str, false);
                return true;
            }
        }
        return false;
    }
}