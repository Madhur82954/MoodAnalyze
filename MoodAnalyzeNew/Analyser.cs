using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzeNew
{
    public class Analyser
    {
        private string message;
        public string HAPPYMOOD = "Happy";
        public string SADMOOD = "Sad";
        public Analyser(string message)
        {
            this.message = message;
        }

        public string AnalyserMood()
        {
            if (message.Contains("Happy"))
            {
                return HAPPYMOOD;
            }

            else if (message.Contains("Sad"))
            {
                return SADMOOD;
            }
            else if (string.IsNullOrEmpty(message))
            {
                throw new MoodAnalyserException("MoodAnalysisException");
            }
            else
            {
                return HAPPYMOOD;
            }
            
        }
    }
}
