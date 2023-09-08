public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        List<IList<int>> output = new List<IList<int>>();

        for(int y = 0; y<numRows; y++) {
            List<int> row = new List<int>();

            for(int x = 0; x<y+1; x++) {
                int triangle; 
                if(x==0 || x==y) {
                    triangle = 1;
                }
                else {
                    triangle = output[y-1][x-1] + output[y-1][x];
                }

                row.Add(triangle);
            }
            output.Add(row);
        }

        return output;
    }
}