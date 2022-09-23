public class Solution {

  Dictionary<KeyValuePair<string, Index>, bool> lookuptab = new Dictionary<KeyValuePair<string, Index>, bool>();
    public  bool matching(IList<string> wordDict, string s, int index)
    {
        if (index == s.Length) return true;
        for (int i = 0; i < wordDict.Count; i++)
        {
            if (index + wordDict[i].Length <= s.Length)
            {
                string str = s.Substring(index, wordDict[i].Length);
                if (str == wordDict[i])
                {
                    if (lookuptab.ContainsKey(new KeyValuePair<string, Index>(str, index)))
                        return lookuptab[new KeyValuePair<string, Index>(str, index)];
                    else
                    {
                         bool res = matching(wordDict, s, index + wordDict[i].Length);
                        lookuptab.Add(new KeyValuePair<string, Index>(str, index), res);
                       if (!res ) continue;
                       else return true ; 
                    }
                }
            }
        }
        return false;
    }


    public  bool WordBreak(string s, IList<string> wordDict)
    {
        bool final = matching(wordDict, s, 0);
        return final;
    }
}

