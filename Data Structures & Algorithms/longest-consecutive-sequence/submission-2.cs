public class Solution {
    public int LongestConsecutive(int[] nums) {
        var n = nums.Length;

        if (n == 0) {
            return 0;
        }

        if (n == 1) {
            return 1;
        }
        
        var set = new HashSet<int>(nums);

        var seqs = new Dictionary<int, int>();

        foreach (var i in set) {
            if (set.Contains(i - 1)){
                continue;
            }

            seqs[i] = 1;
        }

        var max = 1;

        foreach (var i in seqs.Keys) {
            var a = i;
            while (set.Contains(++a)) {
                seqs[i]++;

                if (seqs[i] > max) {
                    max = seqs[i];
                }
            }
        }

        return max;
    }
}
