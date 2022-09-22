using MoodAnalyserProblem;

namespace TestMoodAnalyserProblem
{
    [TestClass]
    public class TestMoodAnalyserUCOne
    {
        [TestMethod]
        public void GivenMessageUCOneTCOne()
        {
            //Arrange
            string msg = "I am in Sad Mood";
            string expected = "sad";

            //Act
            MoodAnalyserUCOne moodAnalyserUCOne = new MoodAnalyserUCOne();
            string actual = moodAnalyserUCOne.AnalyseMood(msg);

            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void GivenMessageUCOneTCTwo()
        {
            string msg = "I am in Happy Mood";
            string expected = "happy";

            MoodAnalyserUCOne moodAnalyserUCOne = new MoodAnalyserUCOne();
            string actual = moodAnalyserUCOne.AnalyseMood(msg);

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
    }
}