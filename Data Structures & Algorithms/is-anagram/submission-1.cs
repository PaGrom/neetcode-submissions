public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var dict = new Dictionary <char, int>(s.Length);

        for (int i = 0; i < s.Length; i++) {
            if (dict.TryGetValue(s[i], out var _)){
                dict[s[i]]++;
            }
            else {
                dict[s[i]] = 1;
            }

            if (dict.TryGetValue(t[i], out var _)){
                dict[t[i]]--;
            }
            else {
                dict[t[i]] = -1;
            }
        }

        return !dict.Values.Any(v => v != 0);
    }
}
