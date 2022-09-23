using MoodAnalyserProblem;

namespace TestMoodAnalyserProblem
{
    [TestClass]
    public class TestMoodAnalyserUCSix
    {
        [TestMethod]
        public void GivenHappyMoodShouldReturnHappy()
        {

            object expected ="HAPPY";
            string mood = MoodAnalyserFactoryUCSix.InvokeAnalyseMood("HAPPY", "AnalyseMood");
            Assert.AreEqual(expected, mood);
            Console.WriteLine(mood);
        }

    }


}
