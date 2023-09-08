public class Solution {
    public char[][] RotateTheBox(char[][] box) {        
        for(int i = 0; i<box.Length; i++) {
            box[i] = UpdateBoxLines(box[i]);
        }

        int w = box.Length;
        int h = box[0].Length;

        char[][] result = new char[h][];
        for(int i = 0; i<h; i++) {
            result[i] = new char[w];
            for(int j = 0; j<w; j++) {
                result[i][j] = box[w-j-1][i];
            }
        }
        return result;
    } 

    char[] UpdateBoxLines(char[] box) {
        for(int i = box.Length-1; i>=0; i--) {
            if(box[i] == '#') {
                int moveTo = 0;
                while(i+moveTo+1<box.Length && box[i+moveTo+1] == '.') {
                    moveTo+=1;
                }
                if(moveTo != 0) {
                    box[i] = '.';
                    box[i+moveTo] = '#';
                }
            }
        }
        return box;
    }
}