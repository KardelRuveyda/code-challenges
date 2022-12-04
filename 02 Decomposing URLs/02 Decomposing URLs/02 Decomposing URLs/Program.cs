using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Decomposing_URLs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exampleUrl = "www.docs.microsoft.com/dotnet/csharp/whats-new/csharp-version-history";
            var components = BreakdownURL(exampleUrl);
            foreach (var item in components)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }

        public static string[] BreakdownURL(string urlString)
        {
            //1 
            string first = urlString.Remove(0, 4);

            //2
            string second = first.Replace("-", " ");

            //3
            string[] components = second.Split('/');

            //Alternative ; 

            string[] components2 = urlString.Remove(0, 4).Replace("-", " ").Split('/');


            return components;
        }
    }
}
