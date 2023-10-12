/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        int length = mountainArr.Length();
        
        int maxIdx = length - 1;
        int minIdx = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        int i=-1;
        
        while(minIdx<=maxIdx){
            int midIdx = (int)Math.Floor((maxIdx+minIdx)/2f);
            Console.WriteLine(midIdx);
    
            float slope = GetMountarinValueAt(midIdx+1) -  GetMountarinValueAt(midIdx);
            if(slope > 0) minIdx = midIdx + 1;
            else {
                if(GetMountarinValueAt(midIdx-1) < GetMountarinValueAt(midIdx))
                {
                    i = midIdx;
                    break;
                }
                maxIdx = midIdx - 1;
            }
        }
        
        Console.WriteLine("i = " + i);
        
        int output = BinarySearchLeftMountain(target, 0, i);
        if(output == -1) 
            output = BinarySearchRightMountain(target, i, length-1);   
        return output;
        
        
        
        int BinarySearchLeftMountain(int t, int min, int max) {
            int mid;
            while(min<=max) {
                mid = (int)Math.Round((min+max)/2f);
                Console.WriteLine(mid + " : " + GetMountarinValueAt(mid));
                if(GetMountarinValueAt(mid) == t)
                    return mid;
                else if(GetMountarinValueAt(mid) > t)
                    max = mid - 1;
                else {
                    min = mid + 1;
                }
            }
            Console.WriteLine("not in left");
            return -1;
        }
        
        int BinarySearchRightMountain(int t, int min, int max) {
            int mid;
            while(min<=max) {
                mid = (int)Math.Round((min+max)/2f);
                
                if(GetMountarinValueAt(mid) == t)
                    return mid;
                else if(GetMountarinValueAt(mid) < t)
                    max = mid - 1;
                else {
                    min = mid + 1;
                }
            }
            return -1;
        }
        
        int GetMountarinValueAt(int idx) {
            if(dict.ContainsKey(idx))
                return dict[idx];
            
            dict.Add(idx, mountainArr.Get(idx));
            return dict[idx];
        }
    }
}