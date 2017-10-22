using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class foldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int k = numbers.Length / 4;
            int[] leftArr = numbers.Take(k).ToArray();
            int[] middle = numbers.Skip(k).Take(k * 2).ToArray();
            int[] rightarr = numbers.Skip(k * 3).Take(k).ToArray();
            
            //Now we must revers left and right Arr
            Array.Reverse(leftArr);
            Array.Reverse(rightarr);

            int[] result = new int[k*2];

            for (int i = 0; i < k; i++)
            {
                result[i] = middle[i] + leftArr[i];
                result[i + k] = middle[i + k] + rightarr[i];
                
            }
            Console.WriteLine($"{String.Join(" ", result)}");
        }
    }

}
