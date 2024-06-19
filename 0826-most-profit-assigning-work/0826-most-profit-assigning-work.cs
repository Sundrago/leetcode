public class Solution {
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker) {
        List<Tuple<int,int>> tuples = new();
        for(int i = 0; i<difficulty.Length; i++)
            tuples.Add(new (difficulty[i], profit[i]));
        
        tuples = tuples.OrderBy(i => i.Item2).ToList();
        Array.Sort(worker);
        
        int maxIdx = tuples.Count - 1;
        int answer = 0;
        
        for(int i = worker.Length-1; i>=0; i--) {
            while(maxIdx>=0 && worker[i] < tuples[maxIdx].Item1) {
                maxIdx -= 1;
                if(maxIdx<0) {
                    maxIdx = -1;
                    break;
                }
            }
            
            if(maxIdx == -1) continue;
            else {
                answer += tuples[maxIdx].Item2;
                Console.WriteLine(tuples[maxIdx].Item2);
            }
        }
        
        return answer;
    }
}