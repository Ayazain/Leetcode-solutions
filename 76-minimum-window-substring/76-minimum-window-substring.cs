public class Solution {
      public static bool compare(Dictionary<char, int> truechar, Dictionary<char, int> chare)
    {
        bool ret = true;
        foreach (KeyValuePair<char, int> x in truechar)
        {
            if (x.Value > chare[x.Key])
                return false;
        }
        return ret;
    }
    public string MinWindow(string t, string s) {
        Dictionary<char, int> chars = new Dictionary<char, int>();
        Dictionary<char, int> truechars = new Dictionary<char, int>();
        int TotalLen = int.MaxValue; //  a new  Minimum 
        int Current = 0; //Length of sliding window 
        int FinalStart = 0;
        for (int i = 0; i < s.Length; i++)// creating the twe dictionary 
        {
            if (truechars.ContainsKey(s[i]))
            {
                truechars[s[i]]++;
            }
            else
            {
                chars.Add(s[i], 0);
                truechars.Add(s[i], 1);
            }
        }
        int start = 0; int end = 1; //ADOBECODEBANCDDD
        for (end = 0; end < t.Length; end++)
        {
            if (chars.ContainsKey(t[end]))
            {
                chars[t[end]]++;
            }
            Current++;
            while (Current >= s.Length && compare(truechars , chars))
            {
                if (TotalLen > Current)// ubdate Length 
                {
                    TotalLen = Current;
                    FinalStart = start;
                }
                if (chars.ContainsKey(t[start]))
                {
                    chars[t[start]]--;
                }
                Current--;
                start++;
            }
        }
        if (TotalLen == int.MaxValue) return "";
        return t.Substring(FinalStart, TotalLen);
    }
}