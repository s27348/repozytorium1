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
        }

        public static double Average(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }
    }
}