using MoodAnalyserProblem;

namespace TestMoodAnalyserProblem
{
    [TestClass]
    public class TestMoodAnalyserUCFive
    {
        [TestMethod]
        public void GivenMoodAnalyserClassName()
        {

            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactoryUCFive.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser","HAPPY");
            expected.Equals(obj);
        }

    }


}