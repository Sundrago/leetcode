public class Solution {
    public long MakeIntegerBeautiful(long n, int target) {
        if(CheckIfBeautiful(n, target)) return 0;
        
        long count = 0;
        for(int i = n.ToString().Length-1; i>=0; i--) {
            string inputString = n.ToString();
            int index = inputString[i] - '0';
            long addUp = Convert.ToInt64( (10-index) * Math.Pow(10,inputString.Length-i-1) );

            n += addUp;
            count += addUp;
            if(CheckIfBeautiful(n, target)) return count;
        }
        return -1;
    }

    public bool CheckIfBeautiful(long n, int target) {
        string inputString = n.ToString();
        int addUp = 0;
        for(int i = 0; i<inputString.Length; i++) {
            addUp += inputString[i] - '0';
        }
        if(addUp <= target) return true;
        return false;
    }
}