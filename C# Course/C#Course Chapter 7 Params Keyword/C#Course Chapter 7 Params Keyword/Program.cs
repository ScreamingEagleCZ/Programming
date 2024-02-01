using System.Diagnostics.Metrics;
using System.Windows.Markup;

namespace C_Course_Chapter_7_Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Course Chapter 7 - Params keyword aka passing multiple not predefined parameters into a method
            int[] seq1 = { 4, 7, 9, 2, -24, 56 };
            int[] seq2 = { 56, 98, -23, 10, 76 };
            int[] seq3 = { 98, -67, 46, 475, 12 };

            ShowArray(seq1);
            ShowArray(seq2);
            ShowArray(seq3);
            Delimiter();

            Console.WriteLine("Sums of arrays: " + Sum(seq1) + ", " + Sum(seq2) + ", " + Sum(seq3) + ".");
            Console.WriteLine("Average of arrays: " + Average(seq1) + ", " + Average(seq2) + ", " + Average(seq3) + ".");
            Console.WriteLine("Minimum number in arrays: " + Min(seq1) + ", " + Min(seq2) + ", " + Min(seq3) + ".");
            Console.WriteLine("Maximum number in arrays: " + Max(seq1) + ", " + Max(seq2) + ", " + Max(seq3) + ".");

        }
        public static void ShowArray(params int[] seq)
        {
            Console.WriteLine($"Values: ");
            foreach (var num in seq)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
        }
        public static int Min(params int[] seq)
        {
            int min = int.MaxValue; // Assign maximum possible value of integer to min value
            foreach (int number in seq)
            {
                if (number < min) { min = number; }
            }
            return min;
        }
        public static int Max(params int[] seq)
        {
            int max = int.MinValue; // Assign lowest possible number of integer to variable
            foreach (int item in seq)
            {
                if (item > max) { max = item; }
            }
            return max;
        }
        public static double Average(params int[] seq) 
        {
            int counter = 0;
            int total = 0;
            double result = 0;
            foreach (var item in seq)
            {
                counter++;
                total += item;
            }
            result = (double)total / (double)counter;
            return result;

        }
        public static int Sum(params int[] numbers) // Params parameter must be only one and only used as last
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }
        public static void Delimiter()
        {
            Console.WriteLine("********************");
            Console.WriteLine();
        }
    }
   
}
