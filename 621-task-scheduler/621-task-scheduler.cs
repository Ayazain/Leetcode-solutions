public class Solution {
    public int LeastInterval(char[] tasks, int n) {
       
        if (n == 0 ) return tasks.Count() ;
       int[] counter  = new int [26]; int max = 0 , maxCounter =0 ;  
        for (int i = 0; i < tasks.Length; i++) // fill dic with num of rebetetion
        {
          counter[tasks[i]-'A']++; 
          if ( counter[tasks[i]-'A'] ==  max) maxCounter++; 
          else if  (counter[tasks[i]-'A'] > max)
          { 
            max = counter[tasks[i]-'A']  ;
             maxCounter=1; }
          }
     
       
       
        int res  = ((n+1)*(max-1)+1) ; //total for now 
          res+= maxCounter-1 ;
          int temp = res -max ;// rest of me 
          if (tasks.Length-max > temp)
              res += tasks.Length-max -temp ; 
      
          return res; 
    }
}