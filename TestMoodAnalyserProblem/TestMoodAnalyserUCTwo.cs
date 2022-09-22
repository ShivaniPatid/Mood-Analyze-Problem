using MoodAnalyserProblem;

namespace TestMoodAnalyser
{
    [TestClass]
    public class TestMoodAnalyserUCTwo
    {

        [TestMethod]
        public void GivenMessageUCTwoTCOne()
        {
            string msg = null;
            string expected = "happy";

            MoodAnalyserUCTwo moodAnalyserUCTwo = new MoodAnalyserUCTwo(msg);
            string actual = moodAnalyserUCTwo.AnalyseMood();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
    }

}