using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateStringChecking
{
    class Program
    {
        static List<string> BotList = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            var lineCount = File.ReadLines(Environment.CurrentDirectory + "\\allstrings.txt").Count();
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(Environment.CurrentDirectory + "\\allstrings.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (!BotList.Contains(line))
                {
                    BotList.Add(line);
                    string lines = File.ReadAllText(Environment.CurrentDirectory + "\\none_dupe_strings.txt").ToString() + "\r\n" + line;
                    File.WriteAllText(Environment.CurrentDirectory + "\\none_dupe_strings.txt", lines);
                }
                else
                {
                    Console.WriteLine(line + " does already exist...");
                }
                    
            }

            Console.WriteLine(BotList.Count() + " of " + lineCount + " are left... :(");
            Console.ReadLine();
        }
    }
}
