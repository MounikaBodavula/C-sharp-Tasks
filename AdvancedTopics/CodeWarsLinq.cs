using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{

    public class Kata
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = Sum(numbers);
            Console.WriteLine("The sum is: " + result);
            Console.ReadLine();

            char[] chars = { 'T', 'E', 'S', 'T' };
            char charToCount = 'T';
            int count = CountChar(chars, charToCount);
            Console.WriteLine($"The character '{charToCount}' appears {count} times.");
            Console.ReadLine();

            int start = 1;
            int end = 5;
            int[] squares = CalculateSquares(start, end);
            Console.WriteLine("Squares: " + string.Join(", ", squares));
            Console.ReadLine();



        }
        public static int Sum(int[] numbers)
        {
            return numbers?.Sum() ?? 0;

        }

        public static int CountChar(char[] chars, char charToCount)
        {

            return chars?.Count(c => c == charToCount) ?? 0; ;
        }

        public static int[] CalculateSquares(int start, int end)
        {
            return Enumerable.Range(start, end - start + 1)
                             .Select(i => i * i)
                             .ToArray();
        }
    }

}

