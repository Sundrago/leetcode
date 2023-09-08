public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        List<int> zeros = new List<int>();
        
        for(int i=0; i<nums.Length; i++) {
            if(nums[i] == 0) {
                if(i==nums.Length - 1) {
                    zeros.Add(1);
                    break;
                }

                int j = i+1;
                while(nums[j] == 0) {
                    j+=1;
                    if(j>=nums.Length) break;
                }
                int count = j-i;
                // Console.WriteLine("i = " + i + ", j = " + j + ", count = " + count);
                zeros.Add(count);
                i = j;
            }
        }

        long sum = 0;
        foreach(int value in zeros) {
            sum += SumFromOne(value);
        }
        return sum;
    }

    public long SumFromOne(int n) {
        return (long) n * (n + 1) / 2;
    }
}