public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for(int i=0;i<n;i++){

            bool flag = false;
           for(int j=0; j<flowerbed.Length; j++) {

            if(flowerbed[j] == 1) continue;

             bool left = false;
             bool right = false;

             if(j<=0) left = true;
             else if(flowerbed[j-1]==0) left = true;

             if(j>=flowerbed.Length-1) right = true;
             else if(flowerbed[j+1]==0) right = true;

             if(left && right) {
               flowerbed[j] = 1;
               flag = true;
               break;
             } 
           }
           if(!flag) return false;
        }
        return true;
    }
}