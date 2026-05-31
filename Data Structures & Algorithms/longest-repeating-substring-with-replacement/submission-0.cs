public class Solution {
    public int CharacterReplacement(string s, int k) {
        var n = s.Length;
        s = s.ToLower();

        var l = 0;
        var r = 1;

        Span<int> counts = stackalloc int[26];
        counts.Clear();

        counts[s[l] - 'a']++;

        var res = 0;

        while (r < n) {
            var i = s[r] - 'a';
            counts[i]++;
            while (SumAllExteptBigger(counts, k)) {
                var j = s[l] - 'a';
                counts[j]--;
                l++;
            }
            res = int.Max(res, r - l + 1);

            // for (int a = l; a <= r; a++) {
            //     Console.Write(s[a]);
            // }
            // Console.WriteLine();

            r++;
        }

        return res;
    }

    private bool SumAllExteptBigger(Span<int> counts, int k) {
        var max = 0;
        var sum = 0;
        for (int i = 0; i < 26; i++) {
            sum += counts[i];
            if (counts[i] > max) {
                max = counts[i];
            }
        }

        var e = sum - max;

        // Console.WriteLine($"sum: {sum} max: {max} e: {e} k: {k}");

        return e > k;
    }
}
