public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<int[], List<string>>(new MyEqualityComparer());

        foreach (var str in strs) {
            var arr = new int[26];
            for (int i = 0; i < str.Length; i++) {
                arr[str[i] - 'a']++;
            }

            dict.TryAdd(arr, new List<string>());
            dict[arr].Add(str);
        }

        return dict.Values.ToList();
    }
}

public class MyEqualityComparer : IEqualityComparer<int[]>
{
    public bool Equals(int[] x, int[] y)
    {
        if (x.Length != y.Length)
        {
            return false;
        }
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] != y[i])
            {
                return false;
            }
        }
        return true;
    }

    public int GetHashCode(int[] obj)
    {
        int result = 17;
        for (int i = 0; i < obj.Length; i++)
        {
            unchecked
            {
                result = result * 23 + obj[i];
            }
        }
        return result;
    }
}

