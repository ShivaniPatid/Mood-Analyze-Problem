using System.Security.Claims;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnalyserProblem;

namespace TestMoodAnalyserProblem
{
    [TestClass]
    public class TestMoodAnalyserUCFour
    {
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            
            object expected = new MoodAnalyserUCOne();
            object obj = MoodAnalyserFactoryUCFour.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyserUCOne", "MoodAnalyserUCOne");
            expected.Equals(obj);
        }
        
    }


}