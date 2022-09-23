using MoodAnalyserProblem;

namespace TestMoodAnalyserProblem
{
    [TestClass]
    public class TestMoodAnalyserFactoryUCSeven
    {
        [TestMethod]
        public void GivenHappyMessageReflectorShouldReturnHappy()
        {

            object expected ="HAPPY";
            object result = MoodAnalyserFactoryUCSeven.setField("HAPPY", "message");
            Assert.AreEqual(expected, result);
            Console.WriteLine(result);
        }

    }


}