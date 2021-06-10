using System.Collections.Generic;
using NUnit.Framework;

namespace NameSorter.Tests
{
    [TestFixture]
    public class AlphabeticalAscendingComparer_Tests
    {
        [Test]
        public void CanSortThreeNames()
        {
            Person personA = new("Aaron", "Aaronsen");
            Person personB = new("Barry", "Bates");
            Person personC = new("Caterina", "Cannon");
           
            var testList = new List<Person> { personC, personB, personA };
            var expectedList = new List<Person> { personA, personB, personC };

            testList.Sort(new AlphabeticalAscendingComparer());
            Assert.AreEqual(testList, expectedList);
        }

        [Test]
        public void CanSortThreeNamesSameFirstName()
        {
            Person personA = new("Gary", "Anderson");
            Person personB = new("Gary", "Bannon");
            Person personC = new("Gary", "Cantor");

            var testList = new List<Person> { personB, personC, personA };
            var expectedList = new List<Person> { personA, personB, personC };

            testList.Sort(new AlphabeticalAscendingComparer());
            Assert.AreEqual(testList, expectedList);
        }

        [Test]
        public void CanSortThreeNamesSameLastName()
        {
            Person personA = new("Abel", "Laws");
            Person personC = new("Cain", "Laws");
            Person personX = new("Xavier", "Laws");

            var testList = new List<Person> { personX, personA, personC };
            var expectedList = new List<Person> { personA, personC, personX };

            testList.Sort(new AlphabeticalAscendingComparer());
            Assert.AreEqual(testList, expectedList);
        }

        [Test]
        public void CanSortThreeNamesSameLastNameMultipleGivenNames()
        {
            Person personJ = new("John", "Smith");
            Person personD = new("John Daniel", "Smith");
            Person personM = new("John Michael", "Smith");

            var testList = new List<Person> { personM, personD, personJ };
            var expectedList = new List<Person> { personJ, personD, personM };

            testList.Sort(new AlphabeticalAscendingComparer());
            Assert.AreEqual(testList, expectedList);
        }
    }
}