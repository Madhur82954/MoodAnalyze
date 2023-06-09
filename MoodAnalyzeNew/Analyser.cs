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
            if (string.IsNullOrEmpty(this.message))
            {
                throw new MoodAnalyserException("MoodAnalysisException");
            }
            else if (this.message.Contains("Happy"))
            {
                return HAPPYMOOD;
            }

            else if (this.message.Contains("Sad"))
            {
                return SADMOOD;
            }
            else
            {
                return HAPPYMOOD;
            }
            
        }
    }
}
