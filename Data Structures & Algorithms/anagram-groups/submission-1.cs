public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        Span<int> counts = stackalloc int[26];
        var sb = new StringBuilder(80);

        foreach (var str in strs) {
            counts.Clear();
            for (int i = 0; i < str.Length; i++) {
                counts[str[i] - 'a']++;
            }

            sb.Clear();
            for (int i = 0; i < 26; i++) { 
                sb.Append('#'); sb.Append(counts[i]); 
            }

            var key = sb.ToString();

            if (!dict.TryGetValue(key, out var list)) {
                list = new List<string>();
                dict[key] = list;
            }
            list.Add(str);
        }

        return dict.Values.ToList();
    }
}
