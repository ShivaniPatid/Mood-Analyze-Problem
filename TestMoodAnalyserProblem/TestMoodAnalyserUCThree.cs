using MoodAnalyserProblem;

namespace TestMoodAnalyser
{
    [TestClass]
    public class TestMoodAnalyserUCThree
    {

        [TestMethod]
        public void GivenMessageUCThreeTCOne()
        {
            string msg = null;
            string expected = "Null Mood";

            MoodAnalyserUCThree moodAnalyserUCThree = new MoodAnalyserUCThree(msg);
            string actual = moodAnalyserUCThree.AnalyseMood();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void GivenMessageUCThreeTCTwo()
        {
            string msg = "";
            string expected = "Empty Mood";

            MoodAnalyserUCThree moodAnalyserUCThree = new MoodAnalyserUCThree(msg);
            string actual = moodAnalyserUCThree.AnalyseMood();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
    }
}
