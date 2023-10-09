public class TimeMap {
    private Dictionary<string, List<Data>> datas;
    
    public TimeMap() {
        datas = new Dictionary<string, List<Data>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!datas.ContainsKey(key)) {
            datas.Add(key, new List<Data>());
        }
        datas[key].Add(new Data(value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if(!datas.ContainsKey(key)) return "";
        
        List<Data> valuesList = datas[key];
        
        int maxTimestamp = int.MinValue;
        string maxValue = "";
        
        foreach(Data data in valuesList) {
            if(data.timestamp > timestamp) continue;

            if(data.timestamp > maxTimestamp) {
                maxTimestamp = data.timestamp;
                maxValue = data.value;
            }
        }
        
        return maxValue;
    }
    
    
    public class Data {
        public string value;
        public int timestamp;
        
        public Data(string _value, int _timestamp){
            value = _value;
            timestamp = _timestamp;
        }
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */