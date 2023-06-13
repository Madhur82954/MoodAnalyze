using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyzeNew
{
    public enum Mood
    {
        Happy,
        Sad,
        Invalid
    }
    public class MoodAnalyserFactory
        {
        public static Analyser CreateMoodAnalyser(string message)
        {
            try
            {
                string name = "Analyser";
                Type MoodAnalyserType = Type.GetType(name);
                if (MoodAnalyserType == null)
                {
                    throw new MoodAnalyserException("No such Class Error");
                }
                ConstructorInfo con = MoodAnalyserType.GetConstructor(new[] { typeof(string) });
                if (con == null)
                {
                    throw new MoodAnalyserException("No such Method Error");
                }
                object[] constructor = new object[] { "Incorrect Parameter" };
                Analyser analyser = (Analyser)con.Invoke(new object[] { message });
                return analyser;
            }
            catch(TargetException ex)
            {
                throw new Exception("No such Constructor Error");
            }
        }
        public static void ChangeMood(Analyser moodAnalyzer, string newMood)
        {
            try
            {
                Type moodAnalyzerType = moodAnalyzer.GetType();
                FieldInfo field = moodAnalyzerType.GetField("mood", BindingFlags.Instance | BindingFlags.NonPublic);
                if (field != null)
                {
                    field.SetValue(moodAnalyzer, newMood);
                }
                else
                {
                    throw new MoodAnalyserException("No Such Field Error");
                }
            }
            catch (TargetException ex)
            {
                throw new MoodAnalyserException("No Such Field Error");
            }
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
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Analyser a1 = (Analyser)obj;
            return message == a1.message;
        }

        public override int GetHashCode()
        {
            return message.GetHashCode();
        }
    }
}
