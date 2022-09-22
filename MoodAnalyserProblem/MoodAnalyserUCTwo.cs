using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserUCTwo
    {
        public string message;

        public MoodAnalyserUCTwo(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
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
            catch (Exception ex)
            {
                return "happy";
            }
        }
    }
}
