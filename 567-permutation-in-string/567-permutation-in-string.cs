public class Solution {
   public bool CheckInclusion(string s1, string s2) {
          if (s1.Length > s2.Length) return false;

        char[] s1sorted = s1.ToCharArray();
        Array.Sort(s1sorted);
        string s1SortedString = new String(s1sorted);

        for (int i = 0; i <= s2.Length - s1.Length; i++)
        {
            char[] s2sorted = s2.Substring(i, s1.Length).ToCharArray();
            Array.Sort(s2sorted);
            string s2SortedString = new String(s2sorted);
            if (s1SortedString.CompareTo(s2SortedString) == 0)
                return true;
        }
        return false;
    }

}