using MoodAnalyserProblem;

namespace TestMoodAnalyser
{
    [TestClass]
    public class TestMoodAnalyserUCOneRefactor
    {

        [TestMethod]
        public void GivenMessageUCOneTCOneRepeat()
        {
            string msg = "I am in Sad Mood";
            string expected = "sad";

            MoodAnalyserUCOneRefactor moodAnalyserUCOne = new MoodAnalyserUCOneRefactor(msg);
            string actual = moodAnalyserUCOne.AnalyseMood();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void GivenMessageUCOneTCTwoRepeat()
        {
            string msg = "I am in Happy Mood";
            string expected = "happy";

            MoodAnalyserUCOneRefactor moodAnalyserUCOne = new MoodAnalyserUCOneRefactor(msg);
            string actual = moodAnalyserUCOne.AnalyseMood();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }


    }
}