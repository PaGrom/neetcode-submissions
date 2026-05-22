public class Solution {
    public bool IsPalindrome(string s) {
        var n = s.Length;

        if (n <= 1) {
            return true;
        }

        var i = 0;
        var j = n-1;

        while (i < n && j >= 0) {
            if (!char.IsLetter(s[i]) && !char.IsDigit(s[i])) {
                i++;
                continue;
            }

            if (!char.IsLetter(s[j]) && !char.IsDigit(s[j])) {
                j--;
                continue;
            }

            if (i >= j) {
                break;
            }

            var a = char.ToLower(s[i]);
            var b = char.ToLower(s[j]);

            if (a != b) {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}
