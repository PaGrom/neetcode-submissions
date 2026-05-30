public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var n = s.Length;

        if (n == 0) {
            return 0;
        }

        var res = 1;
        var l = 0;

        var set = new HashSet<char>() {s[l]};

        for (int i = 1; i < n; i++) {
            while (set.Contains(s[i])){
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[i]);
            res = int.Max(res, i - l + 1);
        }

        return res;
    }
}
