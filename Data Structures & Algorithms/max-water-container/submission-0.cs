public class Solution {
    public int MaxArea(int[] heights) {
        var res = 0;
        var n = heights.Length;

        if (n == 0) {
            return res;
        }

        var i = 0;
        var j = n - 1;

        while (i < j) {
            var length = j - i;
            var height = int.Min(heights[i], heights[j]);

            var area = length * height;

            if (area > res) {
                res = area;
            }

            if (heights[i] <= heights[j]) {
                i++;
            }
            else {
                j--;
            }
        }

        return res;
    }
}
