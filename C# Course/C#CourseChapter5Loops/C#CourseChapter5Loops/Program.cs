using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace C_CourseChapter5Loops
{
    internal class Program
    {
        static int EnterNumber()
        {
            int number = -1;
            string userEntry = "";
            Console.Write("Please enter a number for averaging - enter x to end...");
            userEntry = Console.ReadLine();
            if (userEntry == "x") { return -1; }
            bool parsable = int.TryParse(userEntry, out number);
            if (!parsable || number < 1 || number > 20)
            {
                Console.WriteLine("Please enter a valid number between 1 - 20... or x to end");
                EnterNumber();
            }
            return number;
        }
        static void Main(string[] args)
        {
            // C# Course Chapter 4 - Loops

            // For Loop - runs until condition is not true
            for (int i = 1; i <= 20; i+=2)
            {
                Console.WriteLine("For loop "+ i);
            }

            // Do While Loop - Runs at least once, checks condition at end
            int counter = 0;
            int lengthOfText = 0;
            string textFull = "";
            do
            {
                Console.WriteLine("Keep writing words for continue...");
                string text = Console.ReadLine();
                textFull += " ";
                textFull += text;
                lengthOfText = textFull.Length;
                Console.WriteLine("While Loop " + counter);
                counter++;
            } while (lengthOfText < 20);
            Console.WriteLine("Yeah, you succesfully managed to write long enough text - " + textFull + " - which was " + lengthOfText + " characters long...");

            // While Loop - checks first before running the loop
            int c = 0;
            while (c < 10) 
            {
                Console.WriteLine("While Loop " + c);
                c++;
            }
            Console.WriteLine("--------------------");
            Console.WriteLine();


            // Challenge 1 - people counter - upon pressing enter count up when name inserted
            int people = 0;
            string namesList = "";
            string entry = "";
            Console.WriteLine("People Counter - Enter name and press enter - empty to end counting...");
            do
            {
                entry = "";
                string userEntry = Console.ReadLine();
                if (userEntry != "")
                {
                    entry = userEntry;
                    namesList += entry + ", ";
                    people++;
                    Console.WriteLine($"{entry} has been counted. Current number of persons is {people}...");
                }
            } while (entry != "");
            Console.WriteLine($"Total number of persons is {people}.");
            Console.WriteLine($"Names: {namesList}");
            Console.WriteLine("--------------------");
            Console.WriteLine();


            #region Challenge 2
            // Challenge 2 - Averaging until x is entered
            Console.WriteLine("***Averaging mark for students***");
            double total = 0;
            double mark;
            double marksNr = 0;
            double average = 0;
            do
            {
                mark = EnterNumber();
                if (mark > 0 && mark <=20)
                {
                    total += mark;
                    marksNr++;
                    average = total / marksNr;
                    Console.WriteLine($"Last entered value was {mark}, overall {marksNr} marks entered, actual average is {total / marksNr}.");
                    Console.Write("Enter next mark: ");
                }
                
            } while (mark !=-1);
            Console.WriteLine("--------------------");
            Console.Write($"The average mark is {average} over {marksNr} marks entered...");
            #endregion




            Console.WriteLine("");
            Console.WriteLine("Program ended...");
            Console.WriteLine("Press enter to quit...");
            Console.Read();
        }
    }
}
