using Training.Core.Contracts;

namespace Training.Core.NeetCode
{
    public class NeetCode : INeetCode
    {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            var result = new Dictionary<string, List<string>>();

            for (int i = 0; i <= strs.Length- 1; i++)
            {
                var orderedStr = new string(strs[i].OrderBy(s => s).ToArray());


                if (result.TryGetValue(orderedStr, out var found))
                    result[orderedStr].Add(strs[i]);
                else
                    result.Add(orderedStr, new List<string>() { strs[i] });
            }

            return new List<List<string>>(result.Values);
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i<= nums.Length -1; i++)
                if (dic.TryGetValue(nums[i], out var found))
                    dic[nums[i]]++;
                else
                    dic.Add(nums[i], 1);

            return dic.OrderByDescending(dic => dic.Value).Take(k).Select(s=> s.Key).ToArray();
        }
    }
}
