public class Solution {
    public int[] FullBloomFlowers(int[][] flowers, int[] people) {
        
        List<int> startTimes = new List<int>();
        List<int> endTimes = new List<int>();
        
        for(int i = 0; i<flowers.Length; i++) {
            startTimes.Add(flowers[i][0]);
            endTimes.Add(flowers[i][1]);
        }
        
        startTimes.Sort();
        endTimes.Sort();
        
        int[] answer = new int[people.Length];
        int totalFlowers = flowers.Length;
        for(int i = 0; i<people.Length; i++){
            int right = startTimes.BinarySearch(people[i]);
            if(right < 0) right = ~right;
            else
            {
                while(right<flowers.Length-1 && startTimes[right+1]==startTimes[right])
                        right+=1;
                // if(right == flowers.Length-1 && startTimes[right]==people[i])
                //     right+=1;
                right += 1;
            }
            right = totalFlowers - right;
            
            int left = endTimes.BinarySearch(people[i]);
            if(left < 0) left = ~left;
            else 
                while(left>0 && endTimes[left-1]==people[i])
                    left -= 1;
            // Console.WriteLine("left : " + left + " right : " + right);
            
            int count = totalFlowers - left  - right;
            answer[i] = count;
            // Console.WriteLine(count);
        }
        
        return answer;
        // Dictionary<int, int> bloomCounter = new Dictionary<int, int>();
        
//         //possible dates
//         List<int> dates = new List<int>();
//         for(int i = 0; i<people.Length; i++) 
//             if(!dates.Contains(people[i]))
//                 dates.Add(people[i]);
//         dates.Sort();
        
//         //add counts do dictionary
//         int date = 1;
//         List<int> flowerData = new List<int>();
//         List<int> flowerBloomDurationData = new List<int>();
        
//         for(int i = 0; i<flowers.Length; i++) {
//             flowerBloomDurationData.Add(flowers[i][1] - flowers[i][0] + 1);
//             if(flowers[i][0] == 1) {
//                 flowerData.Add(flowerBloomDurationData[i]);
//             } else {
//                 flowerData.Add(-flowers[i][0] + 1);
//             }
//         }
        
//         for(int i = 0; i<dates.Count; i++) {
//             int dateDiff = dates[i] - date;
//             int counter = 0;
//             date = dates[i];
//             // Console.Write("[date " + date + "] ");
//             for(int j = flowerData.Count - 1; j>=0; j--) {
//                 if(flowerData[j] == 0) {
//                     flowerData.RemoveAt(j);
//                     flowerBloomDurationData.RemoveAt(j);
//                     continue;
//                 }
//                 if(flowerData[j] > 0) {
//                     flowerData[j] -= dateDiff;
//                     if(flowerData[j] <= 0)
//                         flowerData[j] = 0;
//                     else 
//                         counter += 1;
//                 } else {
//                     flowerData[j] += dateDiff;
//                     if(flowerData[j] >= 0) {
//                         int datePassed = flowerData[j];
//                         flowerData[j] = flowerBloomDurationData[j] - datePassed;
//                         if(flowerData[j] <= 0)
//                             flowerData[j] = 0;
//                         else counter += 1;
//                     }
//                 }
//                 // Console.Write(flowerData[j] + " ");
//             }            
//             bloomCounter.Add(dates[i], counter);
//             // Console.Write(" : " + counter + "\n");
//         } 
        
//         //answer list
//         int[] answer = new int[people.Length];
        
//         for(int i = 0; i<people.Length; i++) {
//             answer[i] = bloomCounter[people[i]];
//         }
//         return answer;
    }
}