using System.Linq;
using Easy.Solutions.Solutions;
using NUnit.Framework;

namespace Solutions.Tests.EasyTests
{
    public class MoveZeroesTests
    {
        private readonly MoveZeroes_283 _solution = new MoveZeroes_283();

        [TestCase(new int[]{0,2,3,0,4,5,12,0}, new int[] {2,3,4,5,12,0,0,0})]
        public void MoveZeroes(int[] array, int[] expected)
        {
            _solution.MoveZeroes(array);

            Assert.That(array.ToList(), Is.All.EquivalentTo(expected.ToList()));
        }
    }
}
