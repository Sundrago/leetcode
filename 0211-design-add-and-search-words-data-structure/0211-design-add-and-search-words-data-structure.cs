public class WordDictionary {

List<String> dict;

    public WordDictionary() {
        dict = new List<String>();
    }
    
    public void AddWord(string word) {
        if(!dict.Contains(word.ToString()))
            dict.Add(word.ToString());
    }
    
    public bool Search(string word) {
        for(int i=0; i<dict.Count; i++) {
          if(dict[i].Length == word.Length) {
            bool flag = true;
            for(int j=0; j<word.Length; j++) {
                if(word[j] == '.') continue;
                if(word[j] != dict[i][j]) {
                    flag = false;
                    break;
                }
            }
            if(flag) return true;
            }
        }
        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */