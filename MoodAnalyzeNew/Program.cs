using System;

namespace MoodAnalyzeNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Analyser analyser1 = MoodAnalyserFactory.CreateMoodAnalyser("I am in Happy Mood");
                Analyser analyser2 = MoodAnalyserFactory.CreateMoodAnalyser("i am in Sad Mood");
                Console.WriteLine("object1 is "+analyser1);
                Console.WriteLine("object2 is "+analyser2);
                Console.WriteLine("Object are equal :"+analyser1.Equals(analyser2));

                string newMood = "I am in a sad mood";
                MoodAnalyserFactory.ChangeMood(analyser1, newMood);
                Console.WriteLine("Modified Mood: " + analyser1);
                Console.WriteLine("Modified Mood: " + analyser1.AnalyserMood());
            }
            catch (MoodAnalyserException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}
