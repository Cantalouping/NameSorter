using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NameSorter.Tests
{
    [TestFixture]
    public class SortComparerHandler_Tests
    {
        [Test]
        public void CanChooseAscendingComparer()
        {
            var handler = new SortComparerHandler("a");

            var actualComparer = handler.GetComparer();

            Assert.AreEqual(typeof(AlphabeticalAscendingComparer), actualComparer.GetType());
        }

        [Test]
        public void CanChooseDescendingComparer()
        {
            var handler = new SortComparerHandler("d");

            var actualComparer = handler.GetComparer();

            Assert.AreEqual(typeof(AlphabeticalDescendingComparer), actualComparer.GetType());
        }

        [Test]
        public void ReturnsDefaultComparerAsAscending()
        {
            var handler = new SortComparerHandler("");

            var actualComparer = handler.GetComparer();

            Assert.AreEqual(typeof(AlphabeticalAscendingComparer), actualComparer.GetType());

        }
    }
}
