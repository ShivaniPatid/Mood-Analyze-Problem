using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserUCOneRefactor
    {
        public string message;

        public MoodAnalyserUCOneRefactor(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            message = message.ToLower();
            if (message.Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
