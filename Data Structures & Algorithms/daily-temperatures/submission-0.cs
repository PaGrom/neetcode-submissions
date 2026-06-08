public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var n = temperatures.Length;
        var res = new int[n];

        var stack = new Stack<(int, int)>();

        for (int i = 0; i < n; i++) {
            var t = temperatures[i];
            while (stack.Count > 0 && t > stack.Peek().Item1) {
                var pair = stack.Pop();
                res[pair.Item2] = i - pair.Item2;
            }
            stack.Push((t,i));
        }
        return res;
    }
}
