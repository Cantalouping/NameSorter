using System.IO;
using NUnit.Framework;

namespace NameSorter.Tests
{
    [TestFixture]
    public class Sorter_Tests
    {
        //private string testDataPath = TestContext.CurrentContext.TestDirectory + "\\test_data\\";

        //[TestCase("OneNameUnsorted.txt", "OneNameExpected.txt")]
        //[TestCase("TenNamesUnsorted.txt", "TenNamesExpected.txt")]
        //[TestCase("OneHundredNamesUnsorted.txt", "OneHundredNamesExpected.txt")]
        //[TestCase("OneThousandNamesUnsorted.txt", "OneThousandNamesExpected.txt")]
        //public void VariousSizedUnsortedLists_CanProcessInSorter(string testFile, string testExpectedFile)
        //{
        //    var testInputFile = testDataPath + testFile;
        //    var testOutputFile = testDataPath + testExpectedFile;

        //    var testInputFileProcessed = Sorter.Sort(testInputFile, "output.txt").Trim();
        //    var testOutputFileRead = File.ReadAllText(testOutputFile).Trim();

        //    Assert.AreEqual(testInputFileProcessed, testOutputFileRead);
        //}
    }
}