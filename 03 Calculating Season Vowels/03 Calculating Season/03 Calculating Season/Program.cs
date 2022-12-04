using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculating_Season
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int>();

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"How many point did you score in game #{i} ? ");
                int input = int.Parse(Console.ReadLine());
                scores.Add(input);
            }

            PrintStats(scores);
            Console.ReadLine();
        }

        public static void PrintStats(List<int> scores)
        {
            //1 sorting
            scores.Sort();

            //2 lowest 
            int lowest = scores[0];
            Console.WriteLine($"\nLowest scoring game \t -> {lowest}");

            //3 highest 
            int highest = scores[scores.Count - 1];
            Console.WriteLine($"Highest scoring game \t -> {highest}");

            //4 sum

            int sum = 0;

            for (int i = 0; i < scores.Count; i++)
            {
                sum += scores[i];
            }

            Console.WriteLine($"Total season point \t -> {sum}");

            //5

            Console.WriteLine($"Average points/game \t -> {sum / scores.Count}");
        }
    }
}
