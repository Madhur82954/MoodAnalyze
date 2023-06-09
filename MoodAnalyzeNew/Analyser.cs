using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyzeNew
{
    public class MoodAnalyserFactory
    {
        public static Analyser CreateMoodAnalyser()
        {
            Type MoodAnalyserType = typeof(Analyser);
            ConstructorInfo con = MoodAnalyserType.GetConstructor(Type.EmptyTypes);
            Analyser analyser = (Analyser)con.Invoke(null);
            return analyser;
        }
    }
    public class Analyser
    {
        private string message;
        public string HAPPYMOOD = "Happy";
        public string SADMOOD = "Sad";
        public Analyser()
        {
            this.message = "Default mood";
        }

        public string AnalyserMood()
        {
            if (string.IsNullOrEmpty(this.message))
            {
                throw new MoodAnalyserException("Empty Mood");
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
