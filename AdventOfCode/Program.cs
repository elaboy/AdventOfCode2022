using System.Net;
using System.Text;
using System.Xml;

namespace AdventOfCode
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Day1Processing(); 
            Day2Processing();
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

        }
    }
}