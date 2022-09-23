using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        
        public readonly ExceptionType Type;

        public MoodAnalysisException(string msg) : base(msg)
        {

        }

        public MoodAnalysisException(ExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
