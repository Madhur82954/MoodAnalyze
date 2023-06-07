using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzeNew;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Analyser mood = new Analyser();
            string actualresult = "Sad";

            string expectedresult = mood.AnalyserMood("i am in Sad Mood");

            Assert.AreEqual(actualresult, expectedresult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Analyser mood = new Analyser();
            string actualresult = "Happy";

            string expectedresult = mood.AnalyserMood("i am in Any Mood");

            Assert.AreEqual(actualresult, expectedresult);
        }
    }
    }
}
