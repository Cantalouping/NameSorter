using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace NameSorter.Tests
{
    //[TestFixture]
    //public class Processor_Tests
    //{
    //    private string testDataPath = TestContext.CurrentContext.TestDirectory + "\\test_data\\";
    //    private List<Person> onePersonList;
    //    private List<Person> threePersonList;

    //    [SetUp]
    //    public void Setup()
    //    {
    //        var josetteSession = new Person("Josette", "Session");
    //        var kraigMae = new Person("Kraig", "Mae");
    //        var linhCourtemanche = new Person("Linh", "Courtemanche");
    //        var enidSabo = new Person("Enid", "Sabo");
    //        onePersonList = new List<Person> { josetteSession };
    //        threePersonList = new List<Person> { kraigMae, linhCourtemanche, enidSabo };
    //    }

    //    [Test]
    //    public void OneName_CanGetFromFile()
    //    {
    //        var oneNameTextFile = NamesProcessor.GetNamesFromFile(testDataPath + "OneNameUnsorted.txt");
    //        Assert.AreEqual(onePersonList, oneNameTextFile);
    //    }

    //    [Test]
    //    public void ThreeNames_CanGetFromFile()
    //    {
    //        var threeNameTextFile = NamesProcessor.GetNamesFromFile(testDataPath + "ThreeNamesUnsorted.txt");
    //        Assert.AreEqual(threePersonList, threeNameTextFile);
    //    }

    //    [Test]
    //    public void OneName_CanSaveToFile()
    //    {
    //        var oneNameSaveTestFile = NamesProcessor.SaveNamesToFile(onePersonList, testDataPath + "OneNameSaveTest.txt");
    //        Assert.AreEqual("Josette Session", oneNameSaveTestFile);
    //    }

    //    [Test]
    //    public void ThreeNames_CanSaveToFile()
    //    {
    //        var threeNameSaveTestFile = NamesProcessor.SaveNamesToFile(threePersonList, testDataPath + "ThreeNameSaveTest.txt");
    //        var sb = new StringBuilder();
    //        foreach(Person person in threePersonList)
    //        {
    //            sb.AppendLine(person.ToString());
    //        }
    //        Assert.AreEqual(sb.ToString().Trim(), threeNameSaveTestFile);
    //    }
    //}
}