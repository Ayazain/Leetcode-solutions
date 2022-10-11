public class Solution {
   public int FirstMissingPositive(int[] arr) {
          Dictionary<int , bool > lookup = new Dictionary<int , bool >(); 
            
      for (int j = 0 ; j < arr.Length ; j++)
      {
      if(!lookup.ContainsKey(arr[j]))  lookup.Add(arr[j] , true ); 
      }
     
      for (int  i = 1  ; i <= arr.Length ; i++)
      {
        if (!lookup.ContainsKey(i)) return i;
      }
      return arr.Length+1;
    }
}