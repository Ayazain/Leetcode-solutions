using System.Collections.Generic;
public class Solution {
    public int SingleNumber(int[] nums) {
        
   HashSet<int> setter = new HashSet<int>();

int c11 = 0;
for (int i = 0 ; i < nums.Length;i++)
{
    setter.Add(nums[i]);
    c11+=nums[i];
}
int c = 0 ; 
foreach(int x in setter)
c+=(x*2);
return c-c11;
    }
}