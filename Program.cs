using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surfs_up
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String[]> listContest = new List<String[]>();


            string[] info = File.ReadAllLines(@"C:\Users\Diego\Desktop\Scores.txt");

            int counter = 0;
            int minor = 0;
            foreach (string i in info)
            {
                string[] names = i.Split(' ');

                listContest.Add(names);
                if (int.Parse(listContest[counter][1]) < int.Parse(listContest[minor][1]))
                {
                    minor = counter;
                }

                counter++;
            }

            int firstPlace = minor;
            int secondPlace = minor;
            int thirdPlace = minor;


            for (int i = 1; i < listContest.Count; i++)
            {
                if (int.Parse(listContest[firstPlace][1]) < int.Parse(listContest[i][1]))
                {
                    thirdPlace = secondPlace;
                    secondPlace = firstPlace;
                    firstPlace = i;
                }
            }

            Console.WriteLine("The first place in this contest is " + listContest[firstPlace][0] + " with " + listContest[firstPlace][1]);
            Console.WriteLine("The second place in this contest is " + listContest[secondPlace][0] + " with " + listContest[secondPlace][1]);
            Console.WriteLine("The third place in this contest is " + listContest[thirdPlace][0] + " with " + listContest[thirdPlace][1]);
        }
    }
}
            