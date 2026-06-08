public class Solution {
    public int EvalRPN(string[] tokens) {
        var n = tokens.Length;

        var stack = new Stack<int>();

        for (int i = 0; i < n; i++) {
            if (int.TryParse(tokens[i], out var number)) {
                stack.Push(number);
                continue;
            }

            var r = stack.Pop();
            var l = stack.Pop();
            var res = ApplyOperand(l, r, tokens[i][0]);
            stack.Push(res);
        }

        return stack.Pop();
    }

    private int ApplyOperand(int l, int r, char operand) {
        return operand switch {
            '+' => l + r,
            '-' => l - r,
            '*' => l * r,
            '/' => l / r,
            _ => throw new Exception("invalid")
        };
    }
}
