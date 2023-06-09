using System;

namespace MoodAnalyzeNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Analyser analyser = new Analyser(null);
                string result = analyser.AnalyserMood();
                Console.WriteLine(result);
            }
            catch (MoodAnalyserException ex)
            {
                Console.WriteLine("Error is" + ex.Message);
            }
        }
    }
}
