public class BrowserHistory {

    List<String> history = new List<String>();
    int currentIdx;

    public BrowserHistory(string homepage) {
        history.Add(homepage.ToString());
        currentIdx = 0;
    }
    
    public void Visit(string url) {
        //reset history
        int counter = (history.Count()-currentIdx-1);
        for(int i=0; i<counter; i++) {
            history.RemoveAt(history.Count() - 1);
        }

        history.Add(url.ToString());
        currentIdx += 1;
    }
    
    public string Back(int steps) {
        currentIdx -= steps;
        if(currentIdx < 0) currentIdx = 0;

        return history[currentIdx].ToString();
    }
    
    public string Forward(int steps) {
        currentIdx += steps;
        if(currentIdx > history.Count - 1) currentIdx = history.Count - 1;

        return history[currentIdx].ToString();
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */