public class Solution {
    public class Vertex {
        public int idx;
        public int temperature;
        
        public Vertex(int _idx, int _temperature){
            idx = _idx;
            temperature = _temperature;
        }
    }
    
    public int[] DailyTemperatures(int[] temperatures) {
        int[] answers = new int[temperatures.Length];
        List<Vertex> vertexes = new List<Vertex>();
        
        //Init vertexes
        for(int i = 0; i<temperatures.Length; i++) {
            if(i<temperatures.Length-1 && temperatures[i] == temperatures[i+1]) {
                for(int j = i+1; j<temperatures.Length; j++) {
                    if(temperatures[i] != temperatures[j]){
                        i = j-1;
                        vertexes.Add(new Vertex(i, temperatures[i]));
                        break;
                    }
                }
            }
            
            if(i == 0 || i == temperatures.Length-1){
                vertexes.Add(new Vertex(i, temperatures[i]));
                continue;
            }
            
            int slopeA = (temperatures[i] - temperatures[i-1]);
            int slopeB = (temperatures[i+1] - temperatures[i]);
            if( slopeA * slopeB < 0 || (slopeA!=0 && slopeB==0))
                vertexes.Add(new Vertex(i, temperatures[i]));
        }
        
        // Debug 
        // for(int i = 0; i<vertexes.Count; i++) {
        //     Console.Write( "(" + vertexes[i].idx + ")" + vertexes[i].temperature + " ");
        // }
        // Console.WriteLine("");
        
        //Iterate
        for(int i = 0; i<temperatures.Length; i++) {
            
            if(i == temperatures.Length - 1) {
                answers[i] = 0;
                break;
            }
            
            int vertexIdx = FindSlope(i, temperatures[i]);
            if(vertexIdx == -1) {
                answers[i] = 0;
                continue;
            }
            // Console.WriteLine(temperatures[i] + " : " + vertexIdx);
            for(int j = Math.Max(vertexes[vertexIdx].idx, i+1); j<= Math.Min(vertexes[vertexIdx+1].idx, temperatures.Length-1); j++) {
                if(temperatures[i] < temperatures[j]){
                    answers[i] = j-i;
                    break;
                }
                answers[i] = 0;
            }
        }
        
        
//         for(int i = 0; i<temperatures.Length; i++) {
//             if(i >= temperatures.Length - 1) {
//                 answers[i] = 0;
//                 break;
//             }
            
//             for(int j = i+1; j<temperatures.Length; j++) {
//                 if(temperatures[i] < temperatures[j]){
//                     answers[i] = j-i;
//                     break;
//                 }
//                 answers[i] = 0;
//             }
//         }
        
        return answers;
        
        int FindSlope(int idx, int temperature){
            if(vertexes.Count < 2) return -1;
            
            for(int i = 0; i<vertexes.Count - 1; i++) {
                if(vertexes[i+1].idx < idx) {
                    vertexes.RemoveAt(i);
                    return FindSlope(idx, temperature);
                    continue;
                }
                if(vertexes[i].temperature <= temperature && vertexes[i+1].temperature > temperature)
                    return i;
            }
            
            return -1;
        }
    }
}