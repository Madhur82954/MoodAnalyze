using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzeNew
{
    public class Analyser
    {
        public string HAPPYMOOD = "Happy";
        public string SADMOOD = "Sad";

        public string AnalyserMood(string mood)
        {
            if (mood.Contains("Sad"))
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
