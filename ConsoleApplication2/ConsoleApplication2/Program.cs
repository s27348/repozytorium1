using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zmiana 1");
            Console.WriteLine("Zmiana 2");
            Console.WriteLine("Zmiana 3");

            int[] tab = { 1, 3, 10, 2, 9, 0 };
            
            Console.WriteLine(Average(tab));
            Console.WriteLine(MaxValue(tab));

        }

        public static double Average(int[] numbers)
        {
            double sumSumSumSum = 0;
            foreach (int number in numbers)
            {
                sumSumSumSum += number;
            }

            return sumSumSumSum / numbers.Length;
        }
        
        public static int MaxValue(int[] numbers)
        {
            int maxVal = numbers[0];
            foreach (int number in numbers)
            {
                if (number > maxVal)
                {
                    maxVal = number;
                }
            }

            return maxVal;
        }
    }
}