public class Solution {
    public int FindMin(int[] nums) {
        // for(int i=0; i<nums.Length-1; i++) {
        //     if(nums[i] > nums[i+1])
        //         return (nums[i+1]);
        // }
        // return nums[0];
        
        Array.Sort(nums);
        return nums[0];
    }
}