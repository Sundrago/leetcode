public class Solution {
    public int Search(int[] nums, int target) {
        
        if(nums.Length == 0) {
            return -1;
        } else if(nums.Length == 1) {
            if(nums[0] == target) return 0;
            else return -1;
        }
        
        int pivot = 0;
        for(int i = 0; i<nums.Length-1; i++) {
            if(nums[i] > nums[i+1]) {
                pivot = i;
                break;
            }
        }
        pivot += 1;
        
        var left = nums[0..(pivot)];
        var right = nums[(pivot)..nums.Length];
        
        int index = Array.BinarySearch(left, target);
        if(index >= 0) return index;
        
        index = Array.BinarySearch(right, target);
        if(index >= 0) return index + pivot;
        
        return -1;
        
    }
}