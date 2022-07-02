/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
      return   GetBadVersion( n  ,  0 , n) ;
    }
    public int GetBadVersion(int n  ,  int s , int e ) {
        Console.WriteLine("start  =  "+ s + "End =  "+ e) ; 
        if (s == e )
            return s  ; 
        
        int mid =  s + (e-s)/2 ; 
        Console.WriteLine("Mid   =  "+mid);
        if ( IsBadVersion(mid) )
        return     GetBadVersion(n , s , mid) ; 
        else 
         return     GetBadVersion(n , Math.Min(n, mid+1) , e) ;  

    }   
}