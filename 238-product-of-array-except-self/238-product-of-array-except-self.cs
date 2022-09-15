public class Solution {
    public int[] ProductExceptSelf(int[] arr) {
        if(arr.Length <=1) return new int []{};
      // your code goes here
      int []LefttoRight = new int [arr.Length]; 
      int []RighttoLeft = new int [arr.Length]; 
      int []Output = new int [arr.Length]; 
      int mul = 1 ; 
      int mul2= 1 ; 
      for (int i = 0 ; i < arr.Length ; i++) // Storing values of multy
      {
        LefttoRight[i] = mul*arr[i]; 
        mul =  LefttoRight[i]  ; 
        RighttoLeft[arr.Length -i-1] =  mul2*arr[arr.Length -i-1]; 
        mul2 =  RighttoLeft[arr.Length -i-1];
      }
      
       for (int i = 0 ; i < arr.Length ; i++)
      {
         Output[i] = 1 ; 
         if(i>=1) 
           Output[i] = Output[i]*LefttoRight[i-1];
         if(i<arr.Length-1)
            Output[i] =  Output[i]*RighttoLeft[i+1];
      }
      
      return  Output;   
    }
}