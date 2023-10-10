public class SnapshotArray {
    
    List<Dictionary<int, int>> arrayList;
    Dictionary<int, int> dict;
    
    public SnapshotArray(int length) {
        arrayList = new List<Dictionary<int, int>>();
        dict = new Dictionary<int, int>();
    }
    
    public void Set(int index, int val) {
        dict[index] = val;
    }
    
    public int Snap() {
        arrayList.Add(new Dictionary<int, int>(dict));
        dict = new Dictionary<int, int>();
        
        return arrayList.Count -1;
    }
    
    public int Get(int index, int snap_id) {
        
        for(int i = snap_id; i>=0; i--){
            if(arrayList[i].ContainsKey(index))
            return arrayList[i][index];
        }    
        return 0;
    }
}

/**
 * Your SnapshotArray object will be instantiated and called as such:
 * SnapshotArray obj = new SnapshotArray(length);
 * obj.Set(index,val);
 * int param_2 = obj.Snap();
 * int param_3 = obj.Get(index,snap_id);
 */