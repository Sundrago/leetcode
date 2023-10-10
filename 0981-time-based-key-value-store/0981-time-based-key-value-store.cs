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
        
            var comparer = Comparer<Data>.Create((a,b)=>a.timestamp.CompareTo(b.timestamp));
            List<Data> valuesList = datas[key];

            if (timestamp >= valuesList[valuesList.Count - 1].timestamp) return valuesList[valuesList.Count - 1].value;
            if (timestamp < valuesList[0].timestamp) return string.Empty;
            
            //else return string.Empty;

            int index = valuesList.BinarySearch(new Data("", timestamp), comparer);
            if (index < 0) {
                return valuesList[~index - 1].value;
            } else {
                return valuesList[index].value;
            }
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