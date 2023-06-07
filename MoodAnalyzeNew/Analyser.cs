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
            if (this.message.Contains("Sad"))
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
