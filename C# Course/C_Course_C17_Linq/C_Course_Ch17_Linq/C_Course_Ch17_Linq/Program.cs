using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Ch17_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            OddNumbers(numbers);
            Console.ReadKey();
        }
        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers: ");
            // Linq query selects all odd numbers from list of integers and save em to oddNumbers- select selects what will be saved to oddNumbers
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            Console.WriteLine(oddNumbers);
            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }

    
}
