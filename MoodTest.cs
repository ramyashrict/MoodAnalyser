using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
     class MoodTest
        {
            public string Message;
            public MoodTest()
            {
                Message = " ";
            }
            public MoodTest(string Message)
            {
                this.Message = Message;
            }
            public string Analyzer()
            {
                try
                {
                    if (Message == null)
                    {
                        throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Null, "Mood should not be null");
                    }
                    if (Message.Equals(string.Empty))
                    {
                        throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Empty, "Mood should not be empty");
                    }
                    if (Message.Contains("Sad"))
                        return "Sad";
                    else
                        return "Happy";
                }

                catch (NullReferenceException)
                {
                    return "Happy";
                }

            }
        }

    }
}
