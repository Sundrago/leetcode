public class Solution {
    public string ThousandSeparator(int n) {
        string input = n.ToString();
        string tmp = "";
        string output = "";
        int count = 0;
        for(int i=input.Length-1; i>=0; i--) {
            count += 1;
            tmp += input[i];
            if(count%3==0 && i!=0) tmp += ".";
        }
        for(int i=tmp.Length-1; i>=0; i--) {
            output += tmp[i];
        }
        return output;
    }
}