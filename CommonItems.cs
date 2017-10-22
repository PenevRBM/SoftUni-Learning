using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_01homework
{
    class CommonItems
    {
        static void Main(string[] args)
        {
            //Read and insert in arrays
            string[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Use method for left side
            int leftCount = findMaxCommonItems(firstArr, secondArr);
            //Revers the array
            Array.Reverse(firstArr);
            secondArr = secondArr.Reverse().ToArray();
            //Use method for right side
            int rightCount = findMaxCommonItems(firstArr, secondArr);
            //Print the largest count, because in rightCommonItems is bigger we need a right count
            Console.WriteLine($"{Math.Max(leftCount,rightCount)}");




        }
        // Method for Common Items
        private static int findMaxCommonItems(string[] firstArr, string[] secondArr)
        {
            int length = Math.Min(firstArr.Length, secondArr.Length);
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}
