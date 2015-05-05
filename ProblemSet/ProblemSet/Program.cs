using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    class Program
    {
        static string[] AvailableProblems;

        static void Main(string[] args)
        {
            InitProblemSet();
            while (true)
            {
                PrintProblemSet();
                string userinput = GetUserSelection();
            }
        }

        static void InitProblemSet()
        {
            // TODO: use reflection to find out all methods
            AvailableProblems = new string[]
            {
                "Reorder string",
                "Find circular index of two strings"
            };
        }

        static void PrintProblemSet()
        {
            Console.WriteLine("Available problems:");
            for (int i = 0; i < AvailableProblems.Length; i++)
            {
                Console.WriteLine(string.Format("  {0} : {1}", i, AvailableProblems[i]));
            }

            Console.WriteLine();
        }

        static string GetUserSelection()
        {
            Console.Write("Choose a problem (enter a number): ");
            string input = Console.ReadLine();
            Console.WriteLine();
            return input;
        }
    }
}
