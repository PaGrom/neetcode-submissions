public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var n = nums.Length;
        var prefix = new int[n];
        var suffix = new int[n];

        for (int i = 0; i < n; i++) {
            if (i == 0) {
                prefix[i] = 1;
            }
            else {
                prefix[i] = nums[i-1] * prefix[i-1];
            }
            Console.WriteLine(prefix[i]);
        }

        for (int i = n-1; i >= 0; i--) {
            if (i == n-1) {
                suffix[i] = 1;
            }
            else {
                suffix[i] = nums[i+1] * suffix[i+1];
            }
            Console.WriteLine(suffix[i]);
        }

        var res = new int[n];

        for (int i = 0; i < n; i++) {
            res[i] = prefix[i]*suffix[i];
        }

        return res;
    }
}


//  1  1 2 8
// 48 24 6 1