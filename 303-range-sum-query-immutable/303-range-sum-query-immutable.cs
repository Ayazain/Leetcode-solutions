public class NumArray {
    int[] nums ; 

    public NumArray(int[] nums) {
        this.nums = new int [nums.Length];
        for (int i = 0 ; i < nums.Length ; i++)
            this.nums[i] = nums[i];
    }
    
    public int SumRange(int left, int right) {
        int sum = 0 ;
        if(right<left)
            return 0; 
        if(right ==left)
            return nums[left];
        else 
        for (int i = left ; i <= right; i++)
            sum+=nums[i];
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */