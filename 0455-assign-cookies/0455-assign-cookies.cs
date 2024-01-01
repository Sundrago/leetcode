public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        
        int g_count = g.Count();
        int s_count = s.Count();
    
        int g_n = 0;
        int s_n = 0;
        int count = 0;
        
        while(g_n < g_count && s_n < s_count) {
            if(s[s_n] >= g[g_n]) {
                count += 1;
                g_n += 1;
                s_n += 1;
            } else {
                s_n += 1;
            }
        }
        
        return count;
    }
}