using Easy.Solutions.Solutions;
using NUnit.Framework;

namespace Solutions.Tests.EasyTests
{
    internal class StrStrTests
    {
        private readonly StringIsSubstring _solution;

        public StrStrTests()
        {
            _solution = new StringIsSubstring();
        }

        /// <summary>
        /// 28. Implement strStr()
        /// </summary>

        [TestCase("hhqwerty", "hhqw", 0)]
        [TestCase("missipissi", "piss", 5)]
        [TestCase("missipissi", "awd21312", -1)]
        [TestCase("missipissi", "missipissimissipissi", -1)]
        [TestCase("abcabccabcc", "cc", 5)]
        [TestCase("aaaabbbbddddaaaaccccaaaaatttttaaa", "aaaaa", 20)]
        [TestCase("mississippi", "issip", 4)]
        [TestCase("mississippi", "issipi", -1)]
        [TestCase("p", "p", 0)]
        [TestCase("pbc", "c", 2)]
        public void StrStr_Tests(string str, string needle, int expected)
        {
            var actual = _solution.StrStr(str, needle);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
