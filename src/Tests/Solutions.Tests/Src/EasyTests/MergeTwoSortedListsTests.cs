using System.Collections.Generic;
using Easy.Solutions.Src.Solutions;
using NUnit.Framework;
using Shared.Common.Src;

namespace Solutions.Tests.EasyTests
{
    public class MergeTwoSortedListsTests
    {
        private readonly MergeTwoSortedLists_21 _solution;

        public MergeTwoSortedListsTests()
        {
            _solution = new MergeTwoSortedLists_21();
        }

        [Test]
        public void DefaultCase()
        {
            var list1 = LinkedListBuilder.Build(1, 2, 4);
            var list2 = LinkedListBuilder.Build(1, 3, 4);

            var node = _solution.MergeTwoLists(list1, list2);

            Assert.That(node.ToListOfValues(), Is.EquivalentTo(new List<int>() { 1, 1, 2, 3, 4, 4 }));

        }
    }
}
