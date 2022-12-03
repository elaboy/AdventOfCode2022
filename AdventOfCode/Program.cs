using System.Net;
using System.Text;
using System.Xml;

namespace AdventOfCode
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            Day1Processing(); 
            Day2Processing();
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }

    static void Day1Processing()
        {
            int elfCalories = 0;
            
            string[] lines = File.ReadAllLines("Day1Data.txt");
            List<int> submissionFileList = new List<int>();
                        
            foreach (string line in lines)
            {    
                if (line != "")
                {
                    elfCalories = elfCalories + Int32.Parse(line);
                }
                else if (line == "")
                {
                    submissionFileList.Add(elfCalories);
                    elfCalories = 0;
                }
            }

            submissionFileList.Sort();

            foreach (int line in submissionFileList)
            {   
                Console.WriteLine(line);
            }
        }

        static void Day2Processing()
        {

            int totalScore = 0;
            sbyte win = 6; 
            sbyte tie = 3; 
            sbyte lose = 0;
            sbyte rock = 1;
            sbyte paper = 2;
            sbyte scissors = 3;

            //string currentDirectory = Directory.GetCurrentDirectory();

            var match = new Dictionary<string, int>()
            {
                {"A X", rock + tie},
                {"A Y", paper + win},
                {"A Z", scissors + lose},
                {"B X", rock + lose},
                {"B Y", paper + tie},
                {"B Z", scissors + win},
                {"C X", rock + win},
                {"C Y", paper + lose},
                {"C Z", scissors + tie}
            };

            
            string[] data = File.ReadAllLines("Day2Data.txt");
            
            foreach (string line in data)
            {
                foreach (var singleMatch in match)
                {
                    if (singleMatch.Key == line)
                    {
                        totalScore = totalScore + singleMatch.Value;
                        //Console.WriteLine(totalScore);
                    }

                }
            }
            Console.WriteLine("My total score if everything goes according to the strategy guide is: " + totalScore.ToString());
        }
    }
}