namespace Training.Core.Contracts
{
    public interface INeetCode
    {
        bool hasDuplicate(int[] nums);
        List<List<string>> GroupAnagrams(string[] strs);
        int[] TopKFrequent(int[] nums, int k);
        bool ValidParentheses(string s);
        int[] ProductOfArrayExceptSelf(int[] nums);
    }
}
