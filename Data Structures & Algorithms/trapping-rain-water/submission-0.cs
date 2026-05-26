public class Solution {
    public int Trap(int[] height) {
        var n = height.Length;
        if (n <= 1) {
            return 0;
        }

        var res = 0;

        var prefix = new int[n];
        var suffix = new int[n];

        for (int i = 1; i < n; i++) {
            prefix[i] = int.Max(height[i - 1], prefix[i - 1]);
        }

        // Console.WriteLine(string.Join(' ', prefix));

        for (int j = n - 2; j >= 0; j--) {
            suffix[j] = int.Max(suffix[j + 1], height[j + 1]);
        }

        // Console.WriteLine(string.Join(' ', suffix));

        for (int i = 0; i < n; i++) {
            var a = int.Min(prefix[i], suffix[i]) - height[i];
            if (a > 0) {
                res += a;
            }
        }

        return res;
    }
}
