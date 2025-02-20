namespace Training.Core.Tests.NeetCode
{
    public class NeetCodeTests
    {
        private Core.NeetCode.NeetCode _neetCode;

        public NeetCodeTests()
        {
            _neetCode = new Core.NeetCode.NeetCode();
        }

        [Fact]
        public void CaseOne()
        {
            var list = new List<string>() { "act", "pots", "tops", "cat", "stop", "hat" }.ToArray();

            var result = _neetCode.GroupAnagrams(list);

            Assert.Equal(3, result.Count);
        }
    }
}
