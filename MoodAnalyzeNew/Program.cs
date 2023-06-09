using System;

namespace MoodAnalyzeNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Analyser analyser = MoodAnalyserFactory.CreateMoodAnalyser();
                string result = analyser.AnalyserMood();
                Console.WriteLine(result);
            }
            catch (MoodAnalyserException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}
