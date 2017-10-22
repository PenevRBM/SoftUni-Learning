using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =  new List<int>();
            string inputLine = Console.ReadLine();
            while (inputLine != "Exit")
            {
                int number = int.Parse(inputLine);
                numbers.Add(number);
                inputLine = Console.ReadLine();

            }
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
