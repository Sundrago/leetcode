public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int diff = 0;
        int num = -1000000;
        int numCount = 0;
        
        for(int i = 0; i<nums.Length; i++) {
            if(i+diff >= nums.Length) 
                return i;
            
            nums[i] = nums[i+diff];
            
            if(nums[i] != num) {
                num = nums[i];
                numCount = 1;
                // Console.WriteLine("NEW i:" + i + " = " + num);
                continue;
            }
            
            numCount += 1;
            
            if(numCount >= 3) {
                while(nums[i+diff] == num) {
                    diff += 1;
                    // Console.WriteLine("DUPLICATED i:" + i + " diff : " + diff);
                    if(i+diff >= nums.Length)
                        return i;
                }
                
                nums[i] = nums[i+diff];
                num = nums[i];
                numCount = 1;
            }
            
            
        }
        
        return nums.Length  - diff;
    }
}