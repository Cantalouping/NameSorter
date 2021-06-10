using System.Collections.Generic;
using NUnit.Framework;

namespace NameSorter.Tests
{
    [TestFixture]
    public class AlphabeticalDescendingComparer_Tests
    {
        [Test]
        public void CanSortThreeNames()
        {
            Person personA = new("Aaron", "Aaronsen");
            Person personB = new("Barry", "Bates");
            Person personC = new("Caterina", "Cannon");

            var testList = new List<Person> { personB, personA, personC };
            var expectedList = new List<Person> { personC, personB, personA };

            testList.Sort(new AlphabeticalDescendingComparer());
            Assert.AreEqual(testList, expectedList);
        }

        [Test]
        public void CanSortThreeNamesSameFirstName()
        {
            Person personA = new("Gary", "Anderson");
            Person personB = new("Gary", "Bannon");
            Person personC = new("Gary", "Cantor");

            var testList = new List<Person> { personB, personC, personA };
            var expectedList = new List<Person> { personC, personB, personA };

            testList.Sort(new AlphabeticalDescendingComparer());
            Assert.AreEqual(testList, expectedList);
        }

        [Test]
        public void CanSortThreeNamesSameLastName()
        {
            Person personA = new("Abel", "Laws");
            Person personC = new("Cain", "Laws");
            Person personX = new("Xavier", "Laws");

            var testList = new List<Person> { personX, personA, personC };
            var expectedList = new List<Person> { personX, personC, personA };

            testList.Sort(new AlphabeticalDescendingComparer());
            Assert.AreEqual(testList, expectedList);
        }

        [Test]
        public void CanSortThreeNamesSameLastNameMultipleGivenNames()
        {
            Person personJ = new("John", "Smith");
            Person personD = new("John Daniel", "Smith");
            Person personM = new("John Michael", "Smith");

            var testList = new List<Person> { personD, personJ, personM };
            var expectedList = new List<Person> { personM, personD, personJ };

            testList.Sort(new AlphabeticalDescendingComparer());
            Assert.AreEqual(testList, expectedList);
        }
    }
}
