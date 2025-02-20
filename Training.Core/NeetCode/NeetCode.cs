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
            throw new NotImplementedException();
        }
    }
}
