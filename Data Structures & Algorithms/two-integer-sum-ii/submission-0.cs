public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var n = numbers.Length;
        var i = 0;
        var j = n-1;

        while (true) {
            var res = numbers[i] + numbers[j];
            if (res == target) {
                return new int[2] {i+1, j+1};
            }

            if (res > target) {
                j--;
                continue;
            }

            if (res < target) {
                i++;
            }
        }

        return new int[0];
    }
}
