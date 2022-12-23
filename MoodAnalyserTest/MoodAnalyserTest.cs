using MoodAnalyzer.MoodAnalyzer;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodTest
    {
        //MoodAnalyser moodAnalyser;
        //string message = " I am in happy Mood";
        [TestInitialize]
        public void SetUp()
        {
            //moodAnalyser = new MoodAnalyser(message);
        }
        [TestMethod]
        public void TestMethodForHappyMood()

        {
            string expected = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in happy Mood");
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSadMood()

        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad Mood");
            string expected = "sad";
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
    }
}
