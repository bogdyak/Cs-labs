/*****************************TASK*****************************/

// The symbolic array stores the names and initials of the students of the class.
// It is required to print a list of classes with an indication for each student
// of the number of his namesake.

/***************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, provide the goddamn class list as foolows: \"SURNAME.F.M.\", delimited with a whitespace!");
            char[] input = (Console.ReadLine()).ToCharArray();
            string actualInput = new string(input);
            string[] studentslist = actualInput.Split(' ');
            Dictionary<string, int> occlusions = new Dictionary<string, int>();
            for (int i = 0; i < studentslist.Length; i++)
            {
                int correlations = 0;
                foreach (var a in studentslist)
                {
                    if (studentslist[i].Substring(0, studentslist[i].Length - 4) == a.Substring(0, studentslist[i].Length - 4))
                    {
                        correlations++;
                    }
                }
                occlusions.Add(studentslist[i], correlations - 1);
            }
            foreach (var pair in occlusions)
            {
                Console.WriteLine("Student: " + pair.Key + " Last name correlations: " + pair.Value);
            }
            Console.Read();
        }
    }
}
