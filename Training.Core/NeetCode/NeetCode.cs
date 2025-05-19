using System.Text;
using Training.Core.Contracts;

namespace Training.Core.NeetCode
{
    public class NeetCode : INeetCode
    {
        public bool hasDuplicate(int[] nums)
        {
            var hash = new List<int>();

            for (int i = 0; i<=nums.Length -1; i++)
            {
                if (hash.Exists(h => h == nums[i]))
                    return true;
            }
            return false;
        }


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


        public int[] ProductOfArrayExceptSelf(int[] nums)
        {
            int n = nums.Length;
            var output = new int[n];

            var product = 1;
            var zeroIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                    product = product  * nums[i];
                else zeroIndex = i;
            }

            for (int i = 0; i < n; i++)
                if (nums[i] == 0)
                    output[i] = 0;
                else
                    output[i] = product / nums[i];


            return output;
        }

        public string Encode(IList<string> strs)
        {
            var encoded = new StringBuilder();

            foreach (var s in strs)
            {
                if (s == "") encoded.Append("0|");
                else encoded.Append($"{s.Length}|{s}");
            }

            return encoded.ToString();
        }

        public List<string> Decode(string s)
        {
            var decoded = new List<string>();

            for (int i = 0; i<= s.Length -1; i++)
            {
                if (s[i] == '|' && IsNumber(s[i-1]))
                {
                    var size = int.Parse(s[i-1].ToString());
                    if (size == 0) decoded.Add("");
                    else
                    {
                        var word = s.Substring(i+1, size);
                        decoded.Add(word);
                    }
                }
            }

            return decoded;
        }

        private static bool IsNumber(char v)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            return numbers.Contains(int.Parse(v.ToString()));
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i<= nums.Length -1; i++)
                if (dic.TryGetValue(nums[i], out var found))
                    dic[nums[i]]++;
                else
                    dic.Add(nums[i], 1);

            return dic.OrderByDescending(dic => dic.Value).Take(k).Select(s => s.Key).ToArray();
        }
    }
}
