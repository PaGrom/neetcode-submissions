public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach (var n in nums) {
            dict.TryGetValue(n, out var count);
            dict[n] = --count;
        }
        var pq = new PriorityQueue<int, int>(dict.Select(kv => (kv.Key, kv.Value)));

        var res = new int[k];

        for (int i = 0; i < k; i++) {
            res[i] = pq.Dequeue();
        }

        return res;
    }
}
