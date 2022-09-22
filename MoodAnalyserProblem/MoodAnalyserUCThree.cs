using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserUCThree
    {
        public string message;
        public MoodAnalyserUCThree(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (message == null)
                {
                    throw (new MoodAnalysisException("Null Mood"));
                }
                else
                {
                    throw (new MoodAnalysisException("Empty Mood"));
                }
            }
            catch (MoodAnalysisException ex)
            {
                return ex.Message;
            }
        }
    }


    public class MoodAnalysisException : Exception
    {
        public MoodAnalysisException(string msg) : base(msg)
        {

        }
    }
}

