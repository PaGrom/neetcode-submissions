public class Solution {
    public bool IsPalindrome(string s) {
        var n = s.Length;

        if (n <= 1) {
            return true;
        }

        var i = 0;
        var j = n-1;

        while (i < n && j >= 0) {
            if (!char.IsLetterOrDigit(s[i])) {
                i++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[j])) {
                j--;
                continue;
            }

            if (i >= j) {
                break;
            }

            var a = char.ToLowerInvariant(s[i]);
            var b = char.ToLowerInvariant(s[j]);

            if (a != b) {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}
