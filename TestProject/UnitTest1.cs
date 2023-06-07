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
            string actualresult = "Happy";
            string message = null;
            Analyser mood = new Analyser(message);

            string expectedresult = mood.AnalyserMood();

            Assert.AreEqual(actualresult, expectedresult);
        }
        /*[TestMethod]
        public void TestMethod2()
        {
            string actualresult = "Happy";
            string message = "I am in Any Mood";
            Analyser mood = new Analyser(message);

            string expectedresult = mood.AnalyserMood();

            Assert.AreEqual(actualresult, expectedresult);
        }*/
    }
}

