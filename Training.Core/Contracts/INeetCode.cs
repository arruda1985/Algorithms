namespace Training.Core.Contracts
{
    public interface INeetCode
    {
        List<List<string>> GroupAnagrams(string[] strs);
        int[] TopKFrequent(int[] nums, int k);
        int[] ProductOfArrayExceptSelf(int[] nums);
    }
}
