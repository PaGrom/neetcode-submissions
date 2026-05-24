public class Solution {
    record struct Sum3(int I, int J, int K);
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var n = nums.Length;

        var result = new List<List<int>>();

        var set = new HashSet<Sum3>();

        for (int i = 0; i < n - 2; i++) {
            var j = i + 1;
            var k = n - 1;

            while (j < k) {
                var res = nums[i] + nums[j] + nums[k];

                if (res == 0) {
                    set.Add(new Sum3(nums[i], nums[j], nums[k]));
                    j++;
                }

                if (res < 0) {
                    j++;
                }

                if (res > 0) {
                    k--;
                }
            }
        }

        result = set.Select(s => new List<int>() {s.I, s.J, s.K}).ToList();

        return result;
    }
}
