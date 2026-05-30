public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var m = s1.Length;
        var n = s2.Length;

        if (n < m) {
            return false;
        }

        // Span<int> counts = stackalloc int[26];
        var counts = new int[26];
        // counts.Clear();

        for (int i = 0; i < m; i++) {
            counts[s1[i] - 'a']++;
        }

        // Console.WriteLine(string.Join(' ', dict.Values));

        var l = 0;
        var r = m - 1;

        var dict = new Dictionary<char, int>();
        for (int i = l; i <= r; i++){
            if (!dict.TryGetValue(s2[i], out _)){
                dict[s2[i]] = 0;
            }
            dict[s2[i]]++;
        }

        if (dict.Keys.Where(c => dict[c] != 0).All(c => dict[c] == counts[c - 'a'])) {
            return true;
        }

        while(r < n - 1) {
            l++;
            r++;

            dict[s2[l-1]]--;
            if (!dict.TryGetValue(s2[r], out _)){
                dict[s2[r]] = 0;
            }
            dict[s2[r]]++;

            if (dict.Keys.Where(c => dict[c] != 0).All(c => dict[c] == counts[c - 'a'])) {
                return true;
            }
        }

        return false;
    }
}
