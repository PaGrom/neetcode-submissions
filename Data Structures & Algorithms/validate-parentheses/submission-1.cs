public class Solution {
    public bool IsValid(string s) {
        var l = new HashSet<char> {'(', '{', '['};

        var stack = new Stack<char>();

        var isLeft = (char e) => l.Contains(e); 

        foreach (var c in s) {
            var isl = isLeft(c);

            if (isl) {
                stack.Push(c);
                continue;
            }

            if (!stack.TryPop(out var x)) {
                return false;
            }

            if ((int)x != (int)c-1 && (int)x != (int)c-2) {
                // Console.WriteLine($"{x} : {(int)x} {c}: {(int)c}");
                return false;
            }
        }

        return !stack.TryPop(out _);
    }
}
