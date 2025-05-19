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

        [Fact]
        public void TopKFrequent_CaseOne()
        {
            var list = new List<int> { 1, 2, 2, 3, 3, 3 };

            var result = _neetCode.TopKFrequent([.. list], 2);

            Assert.Equal(2, result[0]);
            Assert.Equal(3, result[1]);
        }

        [Fact]
        public void TopKFrequent_CaseTwo()
        {
            var list = new List<int> { 7, 7 };

            var result = _neetCode.TopKFrequent([.. list], 1);

            Assert.Equal(7, result[0]);
        }

        [Fact]
        public void TopKFrequent_CaseThree()
        {
            var list = new List<int> { 1 };

            var result = _neetCode.TopKFrequent([.. list], 1);

            Assert.Equal(1, result[0]);
        }

        [Fact]
        public void ProductOfArrayExceptSelf()
        {
            var nums = new List<int> { 1, 2, 4, 6 };

            var result = _neetCode.ProductOfArrayExceptSelf([.. nums]);

            Assert.Equal(48, result[0]);
            Assert.Equal(24, result[1]);
            Assert.Equal(12, result[2]);
            Assert.Equal(8, result[3]);
        }

        [Fact]
        public void ProductOfArrayExceptSelfWithZero()
        {
            var nums = new List<int> { -1, 0, 1, 2, 3 };

            var result = _neetCode.ProductOfArrayExceptSelf([.. nums]);

            Assert.Equal(0, result[0]);
            Assert.Equal(-6, result[1]);
            Assert.Equal(0, result[2]);
            Assert.Equal(0, result[3]);
        }
        [Fact]
        public void EncodeDecode()
        {
            var s = new List<string>() { "neet", "code", "love", "you" };
            var encoded = _neetCode.Encode(s);

            var decoded = _neetCode.Decode(encoded);

            Assert.Equal(s, decoded);
        }

        [Fact]
        public void EncodeDecodeVazio()
        {
            var s = new List<string>() { "" };
            var encoded = _neetCode.Encode(s);

            var decoded = _neetCode.Decode(encoded);

            Assert.Equal(s, decoded);
        }

        [Fact]
        public void EncodeDecodeCharacteresEspeciais()
        {
            var s = new List<string>() { "we", "say", ":", "yes", "!@#$%^&*()" };
            var encoded = _neetCode.Encode(s);

            var decoded = _neetCode.Decode(encoded);

            Assert.Equal(s, decoded);
        }

        [Theory]
        [InlineData("({[]})", true)]
        [InlineData("[(])", false)]
        public void ValidParentheses(string s, bool expectedResult)
        {
            var result = _neetCode.ValidParentheses(s);

            Assert.Equal(expectedResult, result);
        }
    }

}
