﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyzeNew
{
    public class MoodAnalyserFactory
    {
        public static Analyser CreateMoodAnalyser()
        {
            try
            {
                Type MoodAnalyserType = typeof(Analyser);
                ConstructorInfo con = MoodAnalyserType.GetConstructor(Type.EmptyTypes);
                Analyser analyser = (Analyser)con.Invoke(null);
                return analyser;
            }
            catch(TargetInvocationException ex)
            {
                throw new Exception("No such class Error");
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
