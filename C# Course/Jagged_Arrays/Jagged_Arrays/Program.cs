using System.Diagnostics.Metrics;
using System.Reflection;

namespace Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Course - Jagged Arrays - Multiple Arrays within array
            // Declaration of Jagged Array
            int[][] jaggedArray = new int[3][]; // Declaration of Initial Array
            jaggedArray[0] = new int[5];    // Optional declaration of length of secondary arrays
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 3, 2, 1 };
            jaggedArray[2] = new int[] { 4, 5 };

            //Alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { 2, 1 },
                new int[] { 3, },
                new int[] { 4, 5, 6, 7}
            };

            Console.WriteLine(jaggedArray2);
            Console.WriteLine($"Value in the middle of Jagged Array is: {jaggedArray[1][1]}");
            for ( int i = 0; i < jaggedArray2.Length; i++ )
            {
                Console.WriteLine("Element {0}", i);
                for ( int j = 0; j < jaggedArray2[i].Length; j++ )
                    Console.WriteLine("Number is: {0}", jaggedArray2[i][j]);
            }
            Delimiter();
            // Nested foreach loop for jagged arrays
            foreach (var row in jaggedArray2)
            {
                foreach (var column in row)
                {
                    Console.WriteLine(column);
                }
            }

            string[][] friends = new string[][]
            {
                new string[] {"Jimmy", "Jebedyah", "Joshua"},
                new string[] {"Bawwy", "Woxane"},
                new string[] {"Lula", "Pixie", "Jenna"}
            };
            for (int i = 0; i < friends.Length; i++)
            {
                for (int j = 0; j < friends[i].Length; j++)
                {
                    string name = friends[i][j];
                    for (int k = 0; k < friends.Length; k++)
                    {
                        for (int l = 0; l < friends[k].Length; l++)
                        {
                            if (name != friends[k][l])
                            {
                                Console.WriteLine($"Hello {name}, this is {friends[k][l]}.");
                            }
                        }
                    }
                }
            }
            Delimiter();
            int[] studentsGrades = new int[] { 1, 3, 1, 2, 2, 1, 4, 5, 1, 1, 2, 4 };
            Console.WriteLine($"Students average is {GetAverageFromInt(studentsGrades)}");
            Delimiter();
            int[] hapiness = new int[] { 1, 2, 3, 4, 5 };
            Rise(hapiness);
            foreach (int i in hapiness)
            {
                Console.WriteLine(i);
            }
            Delimiter();


            Console.ReadKey();
        }
        static double GetAverageFromInt(int[] gradesArray)
        {
            int size = gradesArray.Length;
            int sum = 0;
            double average;
            for (int i = 0;i < size;i++) 
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
        static void Rise(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 2;
            }
        }
        static void Delimiter()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine();
        }
    }
}
