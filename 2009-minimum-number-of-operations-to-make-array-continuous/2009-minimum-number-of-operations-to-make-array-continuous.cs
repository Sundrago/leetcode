public class Solution {
    public int MinOperations(int[] nums) {
        if(nums.Length <= 1) return 0;
        
        Array.Sort(nums);
        
        int maxKey = -1;
        int maxCount = -1;
        
        int minCount = int.MaxValue;
        
        List<int> continuous = new List<int>();
        continuous.Add(nums[0]);
        for(int j = 1; j<nums.Length; j++) {
            if(nums[j-1] != nums[j]){
                continuous.Add(nums[j]);
            }
        }
        
        for(int i = 0; i<continuous.Count; i++) {
            int min = continuous[i];
            int max = continuous[i] + nums.Length;  

            int count = 0;        
            int minIdx = i;
            
            int maxIdx = continuous.BinarySearch(max);
            if(maxIdx<0) {
                maxIdx = ~maxIdx;
            } else maxIdx -= 1;
            
            count = nums.Length - (maxIdx - minIdx);
            if(count < minCount) minCount = count;
        }
        
        return minCount;
    }
}
