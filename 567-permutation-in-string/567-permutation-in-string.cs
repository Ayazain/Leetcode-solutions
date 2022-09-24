public class Solution {
     public bool compare(string s2, Dictionary<char, int> lookup)
    {
        for (int i = 0; i < s2.Length; i++)
        {
            if (!lookup.ContainsKey(s2[i])) return false;
            lookup[s2[i]]--;
            if (lookup[s2[i]] < 0) return false;
        }
        return true;
    }
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;
        Dictionary<char, int> lookup = new Dictionary<char, int>();
      
        for (int i = 0; i < s1.Length; i++)
            if (lookup.ContainsKey(s1[i])) lookup[s1[i]]++;
            else lookup.Add(s1[i], 1);

        for (int i = 0; i <= s2.Length - s1.Length; i++)
        {
            string str = s2.Substring(i, s1.Length);
           if (compare(str, new Dictionary<char, int>(lookup))) return true;
        }
        return false;
    }

}