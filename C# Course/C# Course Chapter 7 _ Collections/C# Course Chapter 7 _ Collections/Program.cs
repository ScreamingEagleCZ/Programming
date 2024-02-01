using System.Collections;

namespace C__Course_Chapter_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Course Chapter 7 - Collections
            // Declaration
            ArrayList myArrayList = new ArrayList();    // Undefined number of objects
            ArrayList myArrayList2 = new ArrayList(100);    //Defined number of objects

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13);
            myArrayList.Add(15.72);
            myArrayList.Add(-754);
            myArrayList.Add("Bobr");
            myArrayList.Add(23);
            myArrayList.Add(13);
            myArrayList.Add(-2);
            myArrayList.Add(452);

            ShowArray(myArrayList);

            // Delete element with specific value from array list
            myArrayList.Remove(13); // Only first occurance is removed by this method

            // Delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine($"Number of elements in array: {myArrayList.Count}.");

            ShowArray(myArrayList);


        }
        static void ShowArray(ArrayList array)
        {
            double sum = 0;
            foreach (object i in array)
            {
                Console.WriteLine(i);
                if (i is int || i is double) { sum += Convert.ToDouble(i);  }
            }
            Console.WriteLine($"Sum of numbers inside array is: {sum}");
        }
    }
}
