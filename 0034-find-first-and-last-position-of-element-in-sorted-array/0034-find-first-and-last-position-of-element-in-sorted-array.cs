public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int startingIdx = -1;
        int endingIdx = -1;
        
        for(int i = 0; i<nums.Length; i++) {
            
            if(nums[i] == target) {
                if(startingIdx == -1) {
                    startingIdx = i;
                }
                if(startingIdx != -1){
                    if(i+1 > nums.Length-1 || nums[i+1] != target)
                        endingIdx = i;
                }
            }
        }
        
        return new int[] {startingIdx, endingIdx};
    }
}