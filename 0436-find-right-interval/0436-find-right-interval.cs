public class Solution {
    public int[] FindRightInterval(int[][] intervals) {
        int[] answer = new int[intervals.Length];
        
        for(int i = 0; i<intervals.Length; i++) {
            int start = intervals[i][1];
            
            int minIdx = -1;
            int minValue = int.MaxValue;
            
            for(int j= 0; j<intervals.Length; j++) {
                if(intervals[j][0] < start) continue;
                
                if(intervals[j][0] < minValue) {
                    minValue = intervals[j][0];
                    minIdx = j;
                }
            }
            answer[i] = minIdx;
        }
        
        return answer;
    }
}